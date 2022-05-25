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
    public partial class Otklic : Form
    {
        AllModel<Otklik> otkliks = new AllModel<Otklik>("Otkliks");
        AllModel<Student> students = new AllModel<Student>("Students");
        AllModel<Predlojenye> prels = new AllModel<Predlojenye>("Predlojenyes");
        string[] vs = new string[]
        {
            "Принят",
            "Не принят"
        };
        private Form _requestForm;
        public Otklic(Form requestForm)
        {
            InitializeComponent();
            VsStatus();
            _requestForm = requestForm;
        }

        private async void AddOtkl_Click(object sender, EventArgs e)
        {
            try
            {
                await new Otklik
                {
                    Id = 0,
                    Tema = NameOtkl.Text,
                    Opisanie = RichOpic.Text,
                    status = StatusBox.SelectedItem.ToString()!,
                    StudentsId = StudentID.SelectedValue as int?,
                    PredlojenyeId = PredlID.SelectedValue as int?,
                }.Add();
                NameOtkl.Text = "";
                RichOpic.Text = "";
                DataOtkl.DataSource = otkliks.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpOtkl_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataOtkl.SelectedRows[0].DataBoundItem is Otklik otkl)
                {
                    otkl.Tema = NameOtkl.Text;
                    otkl.Opisanie = RichOpic.Text;
                    otkl.status = StatusBox.SelectedItem.ToString()!;
                    otkl.StudentsId = StudentID.SelectedValue as int?;
                    otkl.PredlojenyeId = PredlID.SelectedValue as int?;
                    await otkl.Update();
                }
                NameOtkl.Text = "";
                RichOpic.Text = "";
                DataOtkl.DataSource = otkliks.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelOtkl_Click(object sender, EventArgs e)
        {
            await(DataOtkl.SelectedRows[0].DataBoundItem as Otklik)!.Delete();
            DataOtkl.DataSource = otkliks.Objs;
        }

        private  void Otklic_Load(object sender, EventArgs e)
        {
            StudentID.DataSource = students.Objs;
            StudentID.DisplayMember = "Familya";
            StudentID.ValueMember = "Id";

            PredlID.DataSource = prels.Objs;
            PredlID.DisplayMember = "Tema";
            PredlID.ValueMember = "Id";


            DataOtkl.DataSource = otkliks.Objs;
        }

        private void DataOtkl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameOtkl.Text = DataOtkl.Rows[e.RowIndex].Cells[1].Value.ToString();
            RichOpic.Text = DataOtkl.Rows[e.RowIndex].Cells[2].Value.ToString();
            PredlID.Text = DataOtkl.Rows[e.RowIndex].Cells[3].Value.ToString();
            StudentID.Text = DataOtkl.Rows[e.RowIndex].Cells[4].Value.ToString();

            
        }
        public void VsStatus()
        {
            StatusBox.Items.Add(vs[0]);
            StatusBox.Items.Add(vs[1]);
            StatusBox.SelectedIndex = 1;
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            _requestForm.Show();
            this.Close();
        }
    }
}
