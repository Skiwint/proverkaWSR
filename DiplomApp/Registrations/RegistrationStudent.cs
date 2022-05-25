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
    public partial class RegistrationStudent : Form
    {
        AllModel<Group> groups = new AllModel<Group>("Groups");
        AllModel<Teacher> teachers = new AllModel<Teacher>("Teachers");
        private User _user;
        public RegistrationStudent(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private async void RegistrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _user = await _user.Add();

                await new Student
                {
                    Id = 0,
                    Familya = Famil.Text,
                    Imiya = Name1.Text,
                    Otchestvo = Otchestvo.Text,
                    GroupsId = (int?)GroupID.SelectedValue,
                    TeachId = (int?)RykID.SelectedValue,
                    UserId = _user.Id,
                }.Add();

                AutorisationForm autorisation = new AutorisationForm();
                autorisation.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistrationStudent_Load(object sender, EventArgs e)
        {
            GroupID.DataSource = groups.Objs;
            GroupID.ValueMember = "Id";
            GroupID.DisplayMember = "Name";

            RykID.DataSource = teachers.Objs;
            RykID.ValueMember = "Id";
            RykID.DisplayMember = "Familya";
        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            RegistrationForm frm = new RegistrationForm();
            frm.Show();
            this.Hide();
        }
    }
}
