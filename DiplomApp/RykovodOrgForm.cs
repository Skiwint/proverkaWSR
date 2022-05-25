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
    public partial class RykovodOrgForm : Form
    {
        AllModel<Organization> orgs = new AllModel<Organization>("Organizations");
        AllModel<Rykovod> rykovods = new AllModel<Rykovod>("Rykovods");

        private readonly int _userId;
        private int _rykovodId;
        public RykovodOrgForm(int user)
        {
            InitializeComponent();

            _userId = user;
        }

        private async void RyKovodUp_Click(object sender, EventArgs e)
        {
            try
            {
                await new Rykovod
                {
                    Id = _rykovodId,
                    Familya = Famil.Text,
                    Imiya = Name1.Text,
                    Otchestvo = Otchestvo.Text,
                    Doljnost = Dolj.Text,
                    UserId = _userId,
                    OrgId = OrgID.SelectedValue as int?,
                    Phone = NumberPhoneTeh.Text,

                }.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RykovodOrgForm_Load(object sender, EventArgs e)
        {
            try
            {
                var result = rykovods.Objs.FirstOrDefault(student => student.UserId == _userId)!;

                _rykovodId = result.Id;
                Famil.Text = result.Familya;
                Name1.Text = result.Imiya;
                Otchestvo.Text = result.Otchestvo;
                Dolj.Text = result.Doljnost;
                OrgID.DataSource = orgs.Objs;
                OrgID.ValueMember = "Id";
                OrgID.DisplayMember = "Name";
                OrgID.SelectedValue = result.OrgId;


                UserID.Text = result.UserId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutorisationForm autorisation = new AutorisationForm();
            autorisation.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.userId = _userId;
            OrganizationMainForm autorisation = new OrganizationMainForm();
            autorisation.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Predloj predloj = new Predloj(this);
            predloj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Otklic otklic = new Otklic(this);
            otklic.AddOtkl.Enabled = false;
            otklic.DelOtkl.Enabled = false;
            otklic.RichOpic.Enabled = false;
            otklic.NameOtkl.Enabled = false;
            otklic.StudentID.Enabled = false;
            otklic.PredlID.Enabled = false;
            otklic.Show();
            this.Hide();
        }

        private void ResBtn_Click(object sender, EventArgs e)
        {
            Global.userId = _userId;
            ResumeForm resume = new ResumeForm(this);
            resume.Show();
            this.Hide();
        }
    }
}
