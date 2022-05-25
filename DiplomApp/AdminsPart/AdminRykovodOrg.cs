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
    public partial class AdminRykovodOrg : Form
    {
        AllModel<Rykovod> rykovods = new AllModel<Rykovod>("Rykovods");
        AllModel<User> users = new AllModel<User>("Users");
        AllModel<Organization> orgs = new AllModel<Organization>("Organizations");
        public AdminRykovodOrg()
        {
            InitializeComponent();
        }

        private async void AddRykovod_Click(object sender, EventArgs e)
        {
            try
            {
                await new Rykovod
                {
                    Id = 0,
                    Familya = Famil.Text,
                    Imiya = NameR.Text,
                    Otchestvo = Otchestvo.Text,
                    Doljnost = Doljn.Text,
                    UserId = UserID.SelectedValue as int?,
                    OrgId = OrgID.SelectedValue as int?,
                    Phone = MesketPhone.Text,
                }.Add();
                Famil.Text = "";
                NameR.Text = "";
                Otchestvo.Text = "";
                Doljn.Text = "";
                DataRykovod.DataSource = rykovods.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpRykovod_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataRykovod.SelectedRows[0].DataBoundItem is Rykovod rykovod)
                {
                    rykovod.Familya = Famil.Text;
                    rykovod.Imiya = NameR.Text;
                    rykovod.Otchestvo = Otchestvo.Text;
                    rykovod.Doljnost = Doljn.Text;
                    rykovod.UserId = UserID.SelectedValue as int?;
                    rykovod.OrgId = OrgID.SelectedValue as int?;
                    rykovod.Phone = MesketPhone.Text;
                    await rykovod.Update();
                }
                Famil.Text = "";
                NameR.Text = "";
                Otchestvo.Text = "";
                Doljn.Text = "";
                DataRykovod.DataSource = rykovods.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelRykovod_Click(object sender, EventArgs e)
        {
            await(DataRykovod.SelectedRows[0].DataBoundItem as Resume)!.Delete();
            DataRykovod.DataSource = rykovods.Objs;
        }

        private void DataRykovod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Famil.Text = DataRykovod.Rows[e.RowIndex].Cells[1].Value.ToString();
            NameR.Text = DataRykovod.Rows[e.RowIndex].Cells[2].Value.ToString();
            Otchestvo.Text = DataRykovod.Rows[e.RowIndex].Cells[3].Value.ToString();
            Doljn.Text = DataRykovod.Rows[e.RowIndex].Cells[4].Value.ToString();
            UserID.Text = DataRykovod.Rows[e.RowIndex].Cells[5].Value.ToString();
            OrgID.Text = DataRykovod.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void AdminRykovodOrg_Load(object sender, EventArgs e)
        {
            UserID.DataSource = users.Objs;
            UserID.DisplayMember = "Login";
            UserID.ValueMember = "Id";

            OrgID.DataSource = orgs.Objs;
            OrgID.DisplayMember = "Name";
            OrgID.ValueMember = "Id";


            DataRykovod.DataSource = rykovods.Objs;

            DataRykovod.Columns[6].Visible = false;
            DataRykovod.Columns[7].Visible = false;
            DataRykovod.Columns[10].Visible = false;
        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
