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
    public partial class RegistrationRykovod : Form
    {
        AllModel<Organization> orgs = new AllModel<Organization>("Organizations");

        private User _user;
        public RegistrationRykovod(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void RegistrationRykovod_Load(object sender, EventArgs e)
        {
            OrgID.DataSource = orgs.Objs;
            OrgID.DisplayMember = "Name";
            OrgID.ValueMember = "Id";
        }

        private async void RegistrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _user = await _user.Add();

                await new Rykovod
                {
                    Id = 0,
                    Familya = Famil.Text,
                    Imiya = Name1.Text,
                    Otchestvo = Otchestvo.Text,
                    Doljnost = Dolj.Text,
                    OrgId = (int?)OrgID.SelectedValue,
                    Phone = NumberPhoneTeh.Text,
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
