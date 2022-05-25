using DiplomApp.Clasess;
using DiplomApp.Models;
using DiplomApp.zExports;
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
    public partial class TeacherForm : Form
    {

        AllModel<Teacher> teachers = new AllModel<Teacher>("Teachers");
        AllModel<User> users = new AllModel<User>("Users");
        private readonly int _userId;
        private int _teachersId;
        public TeacherForm(int user)
        {
            InitializeComponent();
            _userId = user;
        }

        private async void UpStudent_Click(object sender, EventArgs e)
        {
            try
            {
                await new Teacher
                {
                    Id = _teachersId,
                    Familya = Famil.Text,
                    Imiya = NameT.Text,
                    Otchestvo = Otchestvo.Text,
                    Phone = NumberPhoneTeh.Text,
                    UserId = _userId,
                }.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            try
            {
                var result = teachers.Objs.FirstOrDefault(student => student.UserId == _userId)!;

                _teachersId = result.Id;
                Famil.Text = result.Familya;
                NameT.Text = result.Imiya;
                Otchestvo.Text = result.Otchestvo;
               NumberPhoneTeh.Text = result.Phone;
                UserID.Text = result.UserId.ToString();
                NumberPhoneTeh.Text = result.Phone;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dogovor_Click(object sender, EventArgs e)
        {
            Global.userId = _userId;
            DogovorForm dogovorForm = new DogovorForm();
            dogovorForm.Show();
            this.Close();
        }

        private void GroupFrm_Click(object sender, EventArgs e)
        {
            Global.userId = _userId;
            TeacherExport teacherExport = new TeacherExport();
            teacherExport.Show();
            this.Hide();
        }


        private void BackForm_Click(object sender, EventArgs e)
        {
            AutorisationForm autorisationForm = new AutorisationForm();
            autorisationForm.Show();
            this.Hide();
        }
    }
}
