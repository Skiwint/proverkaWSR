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

namespace DiplomApp
{
    public partial class StudentForm : Form
    {
        AllModel<Student> students = new AllModel<Student>("Students");
        AllModel<Group> groups = new AllModel<Group>("Groups");
        AllModel<Teacher> teachers = new AllModel<Teacher>("Teachers");
        private readonly int _userId;
        private int _studentId;
        public StudentForm(int userId)
        {
            InitializeComponent();
            _userId = userId;

        }



        private async void UpStudent_Click(object sender, EventArgs e)
        {
            try
            {
                await new Student
                {
                    Id = _studentId,
                    Familya = Famil.Text,
                    Imiya = Name1.Text,
                    Otchestvo = Otchestvo.Text,
                    GroupsId = Convert.ToInt32(GroupText.Text),
                    TeachId = Convert.ToInt32(TeacherBox.Text),
                    UserId = _userId,
                    Phone = NumberPhoneTeh.Text,
                }.Update();

                MessageBox.Show("Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            try
            {
                var result = students.Objs.FirstOrDefault(student => student.UserId == _userId)!;

                _studentId = result.Id;
                Famil.Text = result.Familya;
                Name1.Text = result.Imiya;
                Otchestvo.Text = result.Otchestvo;
                
                
                GroupID.DataSource = groups.Objs;
                GroupID.ValueMember = "Id";
                GroupID.DisplayMember = "Name";

                RykID.DataSource = teachers.Objs;
                RykID.ValueMember = "Id";
                RykID.DisplayMember = "Familya";

                GroupID.SelectedValue = result.GroupsId;
                RykID.SelectedValue = result.TeachId;

                GroupText.Text = result.GroupsId.ToString();
                TeacherBox.Text = result.TeachId.ToString();
                NumberPhoneTeh.Text = result.Phone;
                UserID.Text = result.UserId.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResumeForm_Click(object sender, EventArgs e)
        {
            Global.userId = _userId;
            ResumeForm resume = new ResumeForm(this);
            resume.Show();
            this.Hide();
        }

       

        private void BackForm_Click(object sender, EventArgs e)
        {
            AutorisationForm autorisation = new AutorisationForm();
            autorisation.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Predloj predloj = new Predloj(this);
            predloj.RichOpic.Enabled = false;
            predloj.NamePredl.Enabled = false;
            predloj.AddPredl.Enabled = false;
            predloj.UpPredl.Enabled = false;
            predloj.DelPredl.Enabled = false;
            predloj.Show();
            this.Hide();
        }

        private void OtklokBtn_Click(object sender, EventArgs e)
        {
            Otklic otklic = new Otklic(this);
            otklic.StatusBox.Enabled = false;
            otklic.Show();
            this.Hide();
        }
    }
}
