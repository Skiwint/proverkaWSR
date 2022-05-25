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
    public partial class AdminDogovor : Form
    {
        AllModel<Student> students = new AllModel<Student>("Students");
        AllModel<Teacher> teachers = new AllModel<Teacher>("Teachers");
        AllModel<Rykovod> rykovods = new AllModel<Rykovod>("Rykovods");
        AllModel<Dogovor> dogovors = new AllModel<Dogovor>("Dogovors");
        AllModel<Praktika> praktiks = new AllModel<Praktika>("Praktikas");
        public AdminDogovor()
        {
            InitializeComponent();
        }

        private async void AddDogovor_Click(object sender, EventArgs e)
        {
            try
            {
                await new Dogovor
                {
                    Id = 0,
                    DateCreate = DCreate.Value,
                    Name = DogovorName.Text,
                    RykovodId = RykovodBox.SelectedValue as int?,
                    StudentsId = StudentBox.SelectedValue as int?,
                    PraktikId = PraktikBox.SelectedValue as int?,
                }.Add();
                DCreate.Value = DateTime.Now;
                DogovorData.DataSource = dogovors.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpDogovor_Click(object sender, EventArgs e)
        {
            try
            {
                if (DogovorData.SelectedRows[0].DataBoundItem is Dogovor dogovor)
                {

                    dogovor.DateCreate = DCreate.Value;
                    dogovor.Name = DogovorName.Text;
                    dogovor.RykovodId = RykovodBox.SelectedValue as int?;
                    dogovor.StudentsId = StudentBox.SelectedValue as int?;
                    dogovor.PraktikId = PraktikBox.SelectedValue as int?;
                    await dogovor.Update();
                }
                DogovorData.DataSource = dogovors.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelDogovor_Click(object sender, EventArgs e)
        {
            await(DogovorData.SelectedRows[0].DataBoundItem as Dogovor)!.Delete();
            DogovorData.DataSource = dogovors.Objs;
        }

        private void DogovorData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DogovorName.Text = DogovorData.Rows[e.RowIndex].Cells[1].Value.ToString();
            DCreate.Text = DogovorData.Rows[e.RowIndex].Cells[2].Value.ToString();
            RykovodBox.Text = DogovorData.Rows[e.RowIndex].Cells[3].Value.ToString();
            StudentBox.Text = DogovorData.Rows[e.RowIndex].Cells[4].Value.ToString();
            PraktikBox.Text = DogovorData.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void AdminDogovor_Load(object sender, EventArgs e)
        {



            RykovodBox.DataSource = rykovods.Objs;
            RykovodBox.DisplayMember = "Familya";
            RykovodBox.ValueMember = "Id";

            StudentBox.DataSource = students.Objs;
            StudentBox.DisplayMember = "Familya";
            StudentBox.ValueMember = "Id";

            PraktikBox.DataSource = praktiks.Objs;
            PraktikBox.DisplayMember = "Name";
            PraktikBox.ValueMember = "Id";

            DogovorData.DataSource = dogovors.Objs;

            

        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
