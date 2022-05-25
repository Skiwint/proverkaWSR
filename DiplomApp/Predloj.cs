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
    public partial class Predloj : Form
    {
        AllModel<Predlojenye> predls = new AllModel<Predlojenye>("Predlojenyes");
        AllModel<Rykovod> rykovods = new AllModel<Rykovod>("Rykovods");
        private Form _requestForm;
        public Predloj(Form requestForm)
        {
            InitializeComponent();
            _requestForm = requestForm;
        }
        
        private async void AddPredl_Click(object sender, EventArgs e)
        {
            try
            {
                await new Predlojenye
                {
                    Id = 0,
                    Tema = NamePredl.Text,
                    Opisanie = RichOpic.Text,
                    RykovodId = RykovodID.SelectedValue as int?,
                }.Add();
                NamePredl.Text = "";
                RichOpic.Text = "";
                DataPredl.DataSource = predls.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpPredl_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataPredl.SelectedRows[0].DataBoundItem is Predlojenye predl)
                {
                    predl.Tema = NamePredl.Text;
                    predl.Opisanie = RichOpic.Text;
                    predl.RykovodId = RykovodID.SelectedValue as int?;
                    await predl.Update();
                }
                NamePredl.Text = "";
                RichOpic.Text = "";
                DataPredl.DataSource = predls.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelPredl_Click(object sender, EventArgs e)
        {
            await(DataPredl.SelectedRows[0].DataBoundItem as Predlojenye)!.Delete();
            DataPredl.DataSource = predls.Objs;

        }

        private void Predloj_Load(object sender, EventArgs e)
        {
            RykovodID.DataSource = rykovods.Objs;
            RykovodID.DisplayMember = "Familya";
            RykovodID.ValueMember = "Id";


            DataPredl.DataSource = predls.Objs;
        }

        private void DataPredl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NamePredl.Text = DataPredl.Rows[e.RowIndex].Cells[1].Value.ToString();
            RichOpic.Text = DataPredl.Rows[e.RowIndex].Cells[2].Value.ToString();
            RykovodID.Text = DataPredl.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Predloj_FormClosed(object sender, FormClosedEventArgs e)
        {
            _requestForm.Show();
        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            _requestForm.Show();
            this.Close();
        }
    }
}
