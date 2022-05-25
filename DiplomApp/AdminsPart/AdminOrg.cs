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
    public partial class AdminOrg : Form
    {
        AllModel<Organization> orgs = new AllModel<Organization>("Organizations");
        AllModel<Napr> oblast = new AllModel<Napr>("Naprs");
        public AdminOrg()
        {
            InitializeComponent();
        }

        private async void AddOrg_Click(object sender, EventArgs e)
        {
            if(INN.Text.Length <9)
            {
                MessageBox.Show("Неправильный ввод ИНН");
                return;
            }

            try
            {
                await new Organization
                {
                    Id = 0,
                    Name = NameOrg.Text,
                    Adress = Adress.Text,
                    Opisanye = RichOpic.Text,
                    NaprId = IpOblBox.SelectedValue as int?,
                    INN = INN.Text,
                }.Add();
                NameOrg.Text = "";
                Adress.Text = "";
                RichOpic.Text = "";
                DataOrg.DataSource = orgs.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpOrg_Click(object sender, EventArgs e)
        {
            if (INN.Text.Length < 9)
            {
                MessageBox.Show("Неправильный ввод ИНН");
                return;
            }

            try
            {
                if (DataOrg.SelectedRows[0].DataBoundItem is Organization org)
                {
                    org.Name = NameOrg.Text;
                    org.Adress = Adress.Text;
                    org.Opisanye = RichOpic.Text;
                    org.NaprId = IpOblBox.SelectedValue as int?;
                    org.INN = INN.Text;
                    await org.Update();
                }
                NameOrg.Text = "";
                Adress.Text = "";
                RichOpic.Text = "";
                DataOrg.DataSource = orgs.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DellOrg_Click(object sender, EventArgs e)
        {
            await(DataOrg.SelectedRows[0].DataBoundItem as Organization)!.Delete();
            DataOrg.DataSource = orgs.Objs;
        }

        private void DataOrg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameOrg.Text = DataOrg.Rows[e.RowIndex].Cells[1].Value.ToString();
            Adress.Text = DataOrg.Rows[e.RowIndex].Cells[2].Value.ToString();
            RichOpic.Text = DataOrg.Rows[e.RowIndex].Cells[3].Value.ToString();
            IpOblBox.Text = DataOrg.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void AdminOrg_Load(object sender, EventArgs e)
        {
            IpOblBox.DataSource = oblast.Objs;
            IpOblBox.DisplayMember = "Name";
            IpOblBox.ValueMember = "Id";


            DataOrg.DataSource = orgs.Objs;
        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
