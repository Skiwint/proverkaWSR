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
    public partial class AdminTeacher : Form
    {
        AllModel<Teacher> teachers = new AllModel<Teacher>("Teachers");
        AllModel<User> users = new AllModel<User>("Users");

        public AdminTeacher()
        {
            InitializeComponent();
        }

        private async void AddTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                await new Teacher
                {
                    Id = 0,
                    Familya = Famil.Text,
                    Imiya = NameT.Text,
                    Otchestvo = Otchestvo.Text,
                    UserId = UserID.SelectedValue as int?,
                    Phone = MesketPhone.Text,
                }.Add();
                Famil.Text = "";
                NameT.Text = "";
                Otchestvo.Text = "";
                DataTeacher.DataSource = teachers.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataTeacher.SelectedRows[0].DataBoundItem is Teacher teacher)
                {
                    teacher.Familya = Famil.Text;
                    teacher.Imiya = NameT.Text;
                    teacher.Otchestvo = Otchestvo.Text;
                    teacher.UserId = UserID.SelectedValue as int?;
                    teacher.Phone = MesketPhone.Text;
                    await teacher.Update();
                }
                Famil.Text = "";
                NameT.Text = "";
                Otchestvo.Text = "";
                DataTeacher.DataSource = teachers.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelTeacher_Click(object sender, EventArgs e)
        {
            await(DataTeacher.SelectedRows[0].DataBoundItem as Teacher)!.Delete();
            DataTeacher.DataSource = teachers.Objs;
        }

        private void DataTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Famil.Text = DataTeacher.Rows[e.RowIndex].Cells[1].Value.ToString();
            NameT.Text = DataTeacher.Rows[e.RowIndex].Cells[2].Value.ToString();
            Otchestvo.Text = DataTeacher.Rows[e.RowIndex].Cells[3].Value.ToString();
            UserID.Text = DataTeacher.Rows[e.RowIndex].Cells[5].Value.ToString();
            
        }

        private void AdminTeacher_Load(object sender, EventArgs e)
        {
            UserID.DataSource = users.Objs;
            UserID.DisplayMember = "Login";
            UserID.ValueMember = "Id";

            DataTeacher.DataSource = teachers.Objs;

            DataTeacher.Columns[5].Visible = false;
            DataTeacher.Columns[7].Visible = false;
        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
