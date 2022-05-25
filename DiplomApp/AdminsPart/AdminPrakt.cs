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
    public partial class AdminPrakt : Form
    {

        AllModel<Praktika> praktiks = new AllModel<Praktika>("Praktikas");

        public AdminPrakt()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void AddPraktik_Click(object sender, EventArgs e)
        {
            try
            {
                await new Praktika
                {
                    Id = 0,
                    Name = NamePraktik.Text,
                    DateStart = DStart.Value,
                    DateEnd = DEnd.Value,
                }.Add();
                NamePraktik.Text = "";
                DStart.Value = DateTime.Now;
                DEnd.Value = DateTime.Now;
                PraktikData.DataSource = praktiks.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpPraktik_Click(object sender, EventArgs e)
        {
            try
            {
                if (PraktikData.SelectedRows[0].DataBoundItem is Praktika praktika)
                {

                    praktika.DateStart = DStart.Value;
                    praktika.Name = NamePraktik.Text;
                    praktika.DateEnd = DEnd.Value;
                    await praktika.Update();
                }
                PraktikData.DataSource = praktiks.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelPraktik_Click(object sender, EventArgs e)
        {
            await(PraktikData.SelectedRows[0].DataBoundItem as Praktika)!.Delete();
            PraktikData.DataSource = praktiks.Objs;
        }

        private void AdminPrakt_Load(object sender, EventArgs e)
        {
            PraktikData.DataSource = praktiks.Objs;
        }

        private void PraktikData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NamePraktik.Text = PraktikData.Rows[e.RowIndex].Cells[1].Value.ToString();
            DStart.Text = PraktikData.Rows[e.RowIndex].Cells[2].Value.ToString();
            DEnd.Text = PraktikData.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Close();
        }
    }
}
