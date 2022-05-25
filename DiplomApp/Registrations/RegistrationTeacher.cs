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
    public partial class RegistrationTeacher : Form
    {
        
        private User _user;
        public RegistrationTeacher(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private async void RegistrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _user = await _user.Add();

                await new Teacher
                {
                    Id = 0,
                    Familya = Famil.Text,
                    Imiya = Name1.Text,
                    Otchestvo = Otchestvo.Text,
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

        private void BackForm_Click(object sender, EventArgs e)
        {
            RegistrationForm frm = new RegistrationForm();
            frm.Show();
            this.Hide();
        }
    }
}
