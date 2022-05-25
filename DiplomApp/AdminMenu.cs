using DiplomApp.AdminsPart;
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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void UsersFrm_Click(object sender, EventArgs e)
        {
            AdminUsers adminUsers = new AdminUsers();
            adminUsers.Show();
            this.Hide();
        }

        private void StudentsFrm_Click(object sender, EventArgs e)
        {
            AdminStudent adminStudent = new AdminStudent();
            adminStudent.Show();
            this.Hide();
        }

        private void OrgFrm_Click(object sender, EventArgs e)
        {
            AdminOrg adminOrg = new AdminOrg();
            adminOrg.Show();
            this.Hide();
        }

        private void TeacherFrm_Click(object sender, EventArgs e)
        {
            AdminTeacher adminTeacher = new AdminTeacher();
            adminTeacher.Show();
            this.Hide();
        }

        private void RykovodFrm_Click(object sender, EventArgs e)
        {
            AdminRykovodOrg adminRykovodOrg = new AdminRykovodOrg();
            adminRykovodOrg.Show();
            this.Hide();
        }

        private void PredlFrm_Click(object sender, EventArgs e)
        {
            AdminPredloj adminPredloj = new AdminPredloj();
            adminPredloj.Show();
            this.Hide();
        }

        private void DogovorFrm_Click(object sender, EventArgs e)
        {
            AdminDogovor adminDogovor = new AdminDogovor();
            adminDogovor.Show();
            this.Hide();
        }

        private void GroupsFrm_Click(object sender, EventArgs e)
        {
            AdminGroups adminGroups = new AdminGroups();
            adminGroups.Show();
            this.Hide();
        }

        private void OtklikFrm_Click(object sender, EventArgs e)
        {
            AdminOtklik adminOtklik = new AdminOtklik();
            adminOtklik.Show();
            this.Hide();
        }

        private void RoleFrm_Click(object sender, EventArgs e)
        {
            AdminRole adminRole = new AdminRole();
            adminRole.Show();
            this.Hide();
        }

        private void OblastFrm_Click(object sender, EventArgs e)
        {
            AdminOblast adminOblast = new AdminOblast();
            adminOblast.Show();
            this.Hide();
        }

        private void ResumeFrm_Click(object sender, EventArgs e)
        {
            AdminResume adminResume = new AdminResume();
            adminResume.Show();
            this.Hide();
        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            AutorisationForm autorisation = new AutorisationForm();
            autorisation.Show();
            this.Hide();
        }

        private void PraktikAdmin_Click(object sender, EventArgs e)
        {
            AdminPrakt adminPrakt = new AdminPrakt();
            adminPrakt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
