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
    public partial class AdminStudent : Form
    {
        AllModel<Group> groups = new AllModel<Group>("Groups");
        AllModel<Student> students = new AllModel<Student>("Students");
        AllModel<Teacher> teachers = new AllModel<Teacher>("Teachers");
        AllModel<User> users = new AllModel<User>("Users");
        public AdminStudent()
        {
            InitializeComponent();
        }

        private async void AddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                await new Student
                {
                    Id = 0,
                    Familya = Famil.Text,
                    Imiya = NameS.Text,
                    Otchestvo = Otchestvo.Text,
                    UserId = UserID.SelectedValue as int?,
                    GroupsId = GroupID.SelectedValue as int?,
                    TeachId = RykID.SelectedValue as int?,
                    Phone = MesketPhone.Text,
                }.Add();
                Famil.Text = "";
                NameS.Text = "";
                Otchestvo.Text = "";
                DataStudent.DataSource = students.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataStudent.SelectedRows[0].DataBoundItem is Student student)
                {
                    student.Familya = Famil.Text;
                    student.Imiya = NameS.Text;
                    student.Otchestvo = Otchestvo.Text;
                    student.TeachId = RykID.SelectedValue as int?;
                    student.UserId = UserID.SelectedValue as int?;
                    student.GroupsId = GroupID.SelectedValue as int?;
                    student.Phone = MesketPhone.Text;
                    await student.Update();
                }
                Famil.Text = "";
                NameS.Text = "";
                Otchestvo.Text = "";
                DataStudent.DataSource = students.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelStudent_Click(object sender, EventArgs e)
        {
            try
            {
                await (DataStudent.SelectedRows[0].DataBoundItem as Student)!.Delete();
                DataStudent.DataSource = students.Objs;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Famil.Text = DataStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
            NameS.Text = DataStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
            Otchestvo.Text = DataStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
            GroupID.Text = DataStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
            UserID.Text = DataStudent.Rows[e.RowIndex].Cells[5].Value.ToString();
            RykID.Text = DataStudent.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void AdminStudent_Load(object sender, EventArgs e)
        {
            UserID.DataSource = users.Objs;
            UserID.DisplayMember = "Login";
            UserID.ValueMember = "Id";

            RykID.DataSource = teachers.Objs;
            RykID.DisplayMember = "Familya";
            RykID.ValueMember = "Id";

            GroupID.DataSource = groups.Objs;
            GroupID.DisplayMember = "Name";
            GroupID.ValueMember = "Id";

            DataStudent.DataSource = students.Objs;

            DataStudent.Columns[5].Visible = false;
            DataStudent.Columns[6].Visible = false;
            DataStudent.Columns[7].Visible = false;
            DataStudent.Columns[11].Visible = false;

        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
