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
    public partial class AdminOblast : Form
    {
        AllModel<Napr> oblast = new AllModel<Napr>("Naprs");
        public AdminOblast()
        {
            InitializeComponent();
        }

        private async void AddOblast_Click(object sender, EventArgs e)
        {
            try
            {
                await new Napr
                {
                    Id = 0,
                    Name = ObName.Text,
                    Opisanye = RichOpic.Text,
                }.Add();
                ObName.Text = "";
                RichOpic.Text = "";
                DataOblast.DataSource = oblast.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpOblast_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataOblast.SelectedRows[0].DataBoundItem is Napr napr)
                {
                    napr.Name = ObName.Text;
                    napr.Opisanye = RichOpic.Text;
                    await napr.Update();
                }
                ObName.Text = "";
                RichOpic.Text = "";
                DataOblast.DataSource = oblast.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelOblast_Click(object sender, EventArgs e)
        {
            await(DataOblast.SelectedRows[0].DataBoundItem as Napr)!.Delete();
            DataOblast.DataSource = oblast.Objs;
        }

        private void DataOblast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ObName.Text = DataOblast.Rows[e.RowIndex].Cells[1].Value.ToString();
            RichOpic.Text = DataOblast.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void AdminOblast_Load(object sender, EventArgs e)
        {
            DataOblast.DataSource = oblast.Objs;
        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
