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
    public partial class AdminResume : Form
    {
        AllModel<Resume> resumes = new AllModel<Resume>("Resumes");
        AllModel<Student> students = new AllModel<Student>("Students");
        AllModel<Napr> oblast = new AllModel<Napr>("Naprs");
        public AdminResume()
        {
            InitializeComponent();
        }

        private void AdminResume_Load(object sender, EventArgs e)
        {
            StudentID.DataSource = students.Objs;
            StudentID.DisplayMember = "Familya";
            StudentID.ValueMember = "Id";

            OblstBox.DataSource = oblast.Objs;
            OblstBox.DisplayMember = "Name";
            OblstBox.ValueMember = "Id";

            DataResume.DataSource = resumes.Objs;
        }

        private async void AddResume_Click(object sender, EventArgs e)
        {
            try
            {
                await new Resume
                {
                    Id = 0,
                    Name = TemaText.Text,
                    Opisanye = RichOpic.Text,
                    StudentsId = StudentID.SelectedValue as int?,
                    NaprId = OblstBox.SelectedValue as int?,
                }.Add();
                TemaText.Text = "";
                RichOpic.Text = "";
                DataResume.DataSource = resumes.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpResume_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataResume.SelectedRows[0].DataBoundItem is Resume resume)
                {
                   resume.Name = TemaText.Text;
                   resume.Opisanye = RichOpic.Text;
                   resume.StudentsId = StudentID.SelectedValue as int?;
                   resume.NaprId = OblstBox.SelectedValue as int?;
                   await resume.Update();
                }
                TemaText.Text = "";
                RichOpic.Text = "";
                DataResume.DataSource = resumes.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelResume_Click(object sender, EventArgs e)
        {
            await(DataResume.SelectedRows[0].DataBoundItem as Resume)!.Delete();
            DataResume.DataSource = resumes.Objs;
        }

        private void DataResume_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TemaText.Text = DataResume.Rows[e.RowIndex].Cells[1].Value.ToString();
            RichOpic.Text = DataResume.Rows[e.RowIndex].Cells[2].Value.ToString();
            StudentID.Text = DataResume.Rows[e.RowIndex].Cells[3].Value.ToString();
            OblstBox.Text = DataResume.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
