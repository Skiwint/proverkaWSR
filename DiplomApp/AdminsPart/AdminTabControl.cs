using DiplomApp.Clasess;
using DiplomApp.Models;
using DiplomApp.zExports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomApp.AdminsPart
{
    public partial class AdminTabControl : Form
    {
        AllModel<Student> students = new AllModel<Student>("Students");
        
        AllModel<Teacher> teachers = new AllModel<Teacher>("Teachers");
        
        AllModel<Rykovod> rykovods = new AllModel<Rykovod>("Rykovods");
        
        AllModel<Dogovor> dogovors = new AllModel<Dogovor>("Dogovors");
        
        AllModel<Praktika> praktiks = new AllModel<Praktika>("Praktikas");
        
        AllModel<Group> groups = new AllModel<Group>("Groups");
        
        AllModel<Napr> oblast = new AllModel<Napr>("Naprs");
        
        AllModel<Organization> orgs = new AllModel<Organization>("Organizations");
        
        AllModel<Role> roles = new AllModel<Role>("Roles");
        
        AllModel<User> users = new AllModel<User>("Users");
        
        AllModel<Resume> resumes = new AllModel<Resume>("Resumes");
        
        AllModel<Otklik> otkliks = new AllModel<Otklik>("Otkliks");

        AllModel<Predlojenye> predls = new AllModel<Predlojenye>("Predlojenyes");

        public AdminTabControl()
        {
            InitializeComponent();
        }
        private void GetKyrsForGroup()
        {
            KyrsBoxG.Items.Add("3 курс");
            KyrsBoxG.Items.Add("4 курс");
            KyrsBoxG.SelectedIndex = 1;
        }
        public void VsStatus()
        {
            StatusBoxOktl.Items.Add("Принят");
            StatusBoxOktl.Items.Add("Не принят");
            StatusBoxOktl.SelectedIndex = 1;
        }

        //--------------Заполнение выпадающих списков
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //------------------Договора------------------------------
            
            RykovodBoxD.DataSource = rykovods.Objs;
            RykovodBoxD.DisplayMember = "Familya";
            RykovodBoxD.ValueMember = "Id";
                      
            StudentBoxD.DataSource = students.Objs;
            StudentBoxD.DisplayMember = "Familya";
            StudentBoxD.ValueMember = "Id";
                      
            PraktikBoxD.DataSource = praktiks.Objs;
            PraktikBoxD.DisplayMember = "Name";
            PraktikBoxD.ValueMember = "Id";


            //------------------Группы--------------------------------

            GetKyrsForGroup();


            //------------------Организации---------------------------


            IpOblBoxOr.DataSource = oblast.Objs;
            IpOblBoxOr.DisplayMember = "Name";
            IpOblBoxOr.ValueMember = "Id";

            //------------------Отклики--------------------------------

            StudentIDOktl.DataSource = students.Objs;
            StudentIDOktl.DisplayMember = "Familya";
            StudentIDOktl.ValueMember = "Id";

            PredlIDOktl.DataSource = predls.Objs;
            PredlIDOktl.DisplayMember = "Tema";
            PredlIDOktl.ValueMember = "Id";

            VsStatus();

            //------------------Предложения---------------------------

            RykovodIDPredl.DataSource = rykovods.Objs;
            RykovodIDPredl.DisplayMember = "Familya";
            RykovodIDPredl.ValueMember = "Id";

            //------------------Резюме--------------------------------

            StudentIDRes.DataSource = students.Objs;
            StudentIDRes.DisplayMember = "Familya";
            StudentIDRes.ValueMember = "Id";

            OblstBoxRes.DataSource = oblast.Objs;
            OblstBoxRes.DisplayMember = "Name";
            OblstBoxRes.ValueMember = "Id";

            //------------------Руководители от Орг.------------------

            UserIDRyk.DataSource = users.Objs;
            UserIDRyk.DisplayMember = "Login";
            UserIDRyk.ValueMember = "Id";

            OrgIDRyk.DataSource = orgs.Objs;
            OrgIDRyk.DisplayMember = "Name";
            OrgIDRyk.ValueMember = "Id";

            //------------------Студенты-----------------------------

            UserIDStud.DataSource = users.Objs;
            UserIDStud.DisplayMember = "Login";
            UserIDStud.ValueMember = "Id";

            RykIDStud.DataSource = teachers.Objs;
            RykIDStud.DisplayMember = "Familya";
            RykIDStud.ValueMember = "Id";

            GroupIDStud.DataSource = groups.Objs;
            GroupIDStud.DisplayMember = "Name";
            GroupIDStud.ValueMember = "Id";

            //------------------Руководители от техникума-------------

            UserIDTeh.DataSource = users.Objs;
            UserIDTeh.DisplayMember = "Login";
            UserIDTeh.ValueMember = "Id";

            //-------------Пользователя------------------------------

            RoleID.DataSource = roles.Objs;
            RoleID.DisplayMember = "RoleName";
            RoleID.ValueMember = "Id";

        }



        //--------------Заполнение всех DataGridView данными из Бд--------------
        private void AdminTabControl_Load(object sender, EventArgs e)
        {
            DogovorData.DataSource = dogovors.Objs;
            DataGroup.DataSource = groups.Objs;
            DataOblast.DataSource = oblast.Objs;
            DataOrg.DataSource = orgs.Objs;
            DataOtkl.DataSource = otkliks.Objs;
            PraktikData.DataSource = praktiks.Objs;
            DataPredl.DataSource = predls.Objs;
            DataResume.DataSource = resumes.Objs;
            RoleData.DataSource = roles.Objs;
            DataRykovod.DataSource = rykovods.Objs;
            DataStudent.DataSource = students.Objs;
            DataTeacher.DataSource = teachers.Objs;
            DataUser.DataSource = users.Objs;
        }

        private async void AddDogovor_Click(object sender, EventArgs e)
        {
            try
            {
                await new Dogovor
                {
                    Id = 0,
                    DateCreate = DCreateD.Value,
                    Name = DogovorNameD.Text,
                    RykovodId = RykovodBoxD.SelectedValue as int?,
                    StudentsId = StudentBoxD.SelectedValue as int?,
                    PraktikId = PraktikBoxD.SelectedValue as int?,
                }.Add();
                DCreateD.Value = DateTime.Now;
                DogovorData.DataSource = dogovors.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpDogovor_Click(object sender, EventArgs e)
        {
            try
            {
                if (DogovorData.SelectedRows[0].DataBoundItem is Dogovor dogovor)
                {

                    dogovor.DateCreate = DCreateD.Value;
                    dogovor.Name = DogovorNameD.Text;
                    dogovor.RykovodId = RykovodBoxD.SelectedValue as int?;
                    dogovor.StudentsId = StudentBoxD.SelectedValue as int?;
                    dogovor.PraktikId = PraktikBoxD.SelectedValue as int?;
                    await dogovor.Update();
                }
                DogovorData.DataSource = dogovors.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelDogovor_Click(object sender, EventArgs e)
        {
            await(DogovorData.SelectedRows[0].DataBoundItem as Dogovor)!.Delete();
            DogovorData.DataSource = dogovors.Objs;
        }




        private async void AddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                await new Group
                {
                    Id = 0,
                    Name = GroupTextG.Text,
                    Kyrs = KyrsBoxG.SelectedItem.ToString()!,
                }.Add();
                GroupTextG.Text = "";
                DataGroup.DataSource = groups.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGroup.SelectedRows[0].DataBoundItem is Group group)
                {
                    group.Name = GroupTextG.Text;
                    group.Kyrs = KyrsBoxG.SelectedItem.ToString()!;
                    await group.Update();
                }
                DataGroup.DataSource = groups.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelGroup_Click(object sender, EventArgs e)
        {
            await(DataGroup.SelectedRows[0].DataBoundItem as Group)!.Delete();
            DataGroup.DataSource = groups.Objs;
        }






        private async void AddOblast_Click(object sender, EventArgs e)
        {
            try
            {
                await new Napr
                {
                    Id = 0,
                    Name = ObNameO.Text,
                    Opisanye = RichOpicO.Text,
                }.Add();
                ObNameO.Text = "";
                RichOpicO.Text = "";
                DataOblast.DataSource = oblast.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpOblast_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataOblast.SelectedRows[0].DataBoundItem is Napr napr)
                {
                    napr.Name = ObNameO.Text;
                    napr.Opisanye = RichOpicO.Text;
                    await napr.Update();
                }
                ObNameO.Text = "";
                RichOpicO.Text = "";
                DataOblast.DataSource = oblast.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelOblast_Click(object sender, EventArgs e)
        {
            await(DataOblast.SelectedRows[0].DataBoundItem as Napr)!.Delete();
            DataOblast.DataSource = oblast.Objs;
        }






        private async void AddOrg_Click(object sender, EventArgs e)
        {
            if (INNOr.Text.Length < 9)
            {
                MessageBox.Show("Неправильный ввод ИНН");
                return;
            }

            try
            {
                await new Organization
                {
                    Id = 0,
                    Name = NameOrgOr.Text,
                    Adress = AdressOr.Text,
                    Opisanye = RichOpicOr.Text,
                    NaprId = IpOblBoxOr.SelectedValue as int?,
                    INN = INNOr.Text,
                }.Add();
                NameOrgOr.Text = "";
                AdressOr.Text = "";
                RichOpicOr.Text = "";
                DataOrg.DataSource = orgs.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpOrg_Click(object sender, EventArgs e)
        {
            if (INNOr.Text.Length < 9)
            {
                MessageBox.Show("Неправильный ввод ИНН");
                return;
            }

            try
            {
                if (DataOrg.SelectedRows[0].DataBoundItem is Organization org)
                {
                    org.Name = NameOrgOr.Text;
                    org.Adress = AdressOr.Text;
                    org.Opisanye = RichOpicOr.Text;
                    org.NaprId = IpOblBoxOr.SelectedValue as int?;
                    org.INN = INNOr.Text;
                    await org.Update();
                }
                NameOrgOr.Text = "";
                AdressOr.Text = "";
                RichOpicOr.Text = "";
                DataOrg.DataSource = orgs.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DellOrg_Click(object sender, EventArgs e)
        {
            await(DataOrg.SelectedRows[0].DataBoundItem as Organization)!.Delete();
            DataOrg.DataSource = orgs.Objs;
        }





        private async void AddOtkl_Click(object sender, EventArgs e)
        {
            try
            {
                await new Otklik
                {
                    Id = 0,
                    Tema = NameOtklOktl.Text,
                    Opisanie = RichOpicOtk.Text,
                    status = StatusBoxOktl.SelectedItem.ToString()!,
                    StudentsId = StudentIDOktl.SelectedValue as int?,
                    PredlojenyeId = PredlIDOktl.SelectedValue as int?,
                }.Add();
                NameOtklOktl.Text = "";
                RichOpicOtk.Text = "";
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
                    otkl.Tema = NameOtklOktl.Text;
                    otkl.Opisanie = RichOpicOtk.Text;
                    otkl.StudentsId = StudentIDOktl.SelectedValue as int?;
                    otkl.PredlojenyeId = PredlIDOktl.SelectedValue as int?;
                    await otkl.Update();
                }
                NameOtklOktl.Text = "";
                RichOpicOtk.Text = "";
                DataOtkl.DataSource = otkliks.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelOtkl_Click(object sender, EventArgs e)
        {
            try
            {
                await(DataOtkl.SelectedRows[0].DataBoundItem as Otklik)!.Delete();
                DataOtkl.DataSource = otkliks.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        private async void AddPraktik_Click(object sender, EventArgs e)
        {
            try
            {
                await new Praktika
                {
                    Id = 0,
                    Name = NamePraktikPrakt.Text,
                    DateStart = DStartPrakt.Value,
                    DateEnd = DEndPrakt.Value,
                }.Add();
                NamePraktikPrakt.Text = "";
                DStartPrakt.Value = DateTime.Now;
                DEndPrakt.Value = DateTime.Now;
                PraktikData.DataSource = praktiks.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpPraktik_Click(object sender, EventArgs e)
        {
            try
            {
                if (PraktikData.SelectedRows[0].DataBoundItem is Praktika praktika)
                {

                    praktika.DateStart = DStartPrakt.Value;
                    praktika.Name = NamePraktikPrakt.Text;
                    praktika.DateEnd = DEndPrakt.Value;
                    await praktika.Update();
                }
                PraktikData.DataSource = praktiks.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelPraktik_Click(object sender, EventArgs e)
        {
            await(PraktikData.SelectedRows[0].DataBoundItem as Praktika)!.Delete();
            PraktikData.DataSource = praktiks.Objs;
        }






        private async void AddPredl_Click(object sender, EventArgs e)
        {
            try
            {
                await new Predlojenye
                {
                    Id = 0,
                    Tema = NamePredl.Text,
                    Opisanie = RichOpicOtkPredl.Text,
                    RykovodId = RykovodIDPredl.SelectedValue as int?,
                }.Add();
                NamePredl.Text = "";
                RichOpicOtkPredl.Text = "";
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
                    predl.Opisanie = RichOpicOtkPredl.Text;
                    predl.RykovodId = RykovodIDPredl.SelectedValue as int?;
                    await predl.Update();
                }
                NamePredl.Text = "";
                RichOpicOtkPredl.Text = "";
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









        private async void AddResume_Click(object sender, EventArgs e)
        {
            try
            {
                await new Resume
                {
                    Id = 0,
                    Name = TemaTextRes.Text,
                    Opisanye = RichOpicPes.Text,
                    StudentsId = StudentIDRes.SelectedValue as int?,
                    NaprId = OblstBoxRes.SelectedValue as int?,
                }.Add();
                TemaTextRes.Text = "";
                RichOpicPes.Text = "";
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
                    resume.Name = TemaTextRes.Text;
                    resume.Opisanye = RichOpicPes.Text;
                    resume.StudentsId = StudentIDRes.SelectedValue as int?;
                    resume.NaprId = OblstBoxRes.SelectedValue as int?;
                    await resume.Update();
                }
                TemaTextRes.Text = "";
                RichOpicPes.Text = "";
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









        private async void AddRole_Click(object sender, EventArgs e)
        {
            try
            {
                Role role = new Role();
                role.RoleName = TextRole.Text;
                await role.Add();
                TextRole.Text = "";
                RoleData.DataSource = roles.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (RoleData.SelectedRows[0].DataBoundItem is Role role)
                {
                    role.RoleName = TextRole.Text;
                    await role.Update();
                }
                TextRole.Text = "";
                RoleData.DataSource = roles.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelRole_Click(object sender, EventArgs e)
        {
            await(RoleData.SelectedRows[0].DataBoundItem as Role)!.Delete();
            RoleData.DataSource = roles.Objs;
        }










        private async void AddRykovod_Click(object sender, EventArgs e)
        {
            try
            {
                await new Rykovod
                {
                    Id = 0,
                    Familya = FamilRyk.Text,
                    Imiya = NameRyk.Text,
                    Otchestvo = OtchestvoRyk.Text,
                    Doljnost = DoljnRyk.Text,
                    UserId = UserIDRyk.SelectedValue as int?,
                    OrgId = OrgIDRyk.SelectedValue as int?,
                    Phone = MesketPhoneRyk.Text,
                }.Add();
                Famil.Text = "";
                NameRyk.Text = "";
                OtchestvoRyk.Text = "";
                DoljnRyk.Text = "";
                DataRykovod.DataSource = rykovods.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpRykovod_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataRykovod.SelectedRows[0].DataBoundItem is Rykovod rykovod)
                {
                    rykovod.Familya = FamilRyk.Text;
                    rykovod.Imiya = NameRyk.Text;
                    rykovod.Otchestvo = OtchestvoRyk.Text;
                    rykovod.Doljnost = DoljnRyk.Text;
                    rykovod.UserId = UserIDRyk.SelectedValue as int?;
                    rykovod.OrgId = OrgIDRyk.SelectedValue as int?;
                    rykovod.Phone = MesketPhoneRyk.Text;
                    await rykovod.Update();
                }
                Famil.Text = "";
                NameRyk.Text = "";
                OtchestvoRyk.Text = "";
                DoljnRyk.Text = "";
                DataRykovod.DataSource = rykovods.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelRykovod_Click(object sender, EventArgs e)
        {
            await(DataRykovod.SelectedRows[0].DataBoundItem as Resume)!.Delete();
            DataRykovod.DataSource = rykovods.Objs;
        }











        private async void AddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                await new Student
                {
                    Id = 0,
                    Familya = FamilStud.Text,
                    Imiya = NameStud.Text,
                    Otchestvo = OtchestvoStud.Text,
                    UserId = UserIDStud.SelectedValue as int?,
                    GroupsId = GroupIDStud.SelectedValue as int?,
                    TeachId = RykIDStud.SelectedValue as int?,
                    Phone = NumberPhoneStud.Text,
                }.Add();
                FamilStud.Text = "";
                NameStud.Text = "";
                OtchestvoStud.Text = "";
                DataStudent.DataSource = students.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataStudent.SelectedRows[0].DataBoundItem is Student student)
                {
                    student.Familya = FamilStud.Text;
                    student.Imiya = NameStud.Text;
                    student.Otchestvo = OtchestvoStud.Text;
                    student.TeachId = RykIDStud.SelectedValue as int?;
                    student.UserId = UserIDStud.SelectedValue as int?;
                    student.GroupsId = GroupIDStud.SelectedValue as int?;
                    student.Phone = NumberPhoneStud.Text;
                    await student.Update();
                }
                FamilStud.Text = "";
                NameStud.Text = "";
                OtchestvoStud.Text = "";
                DataStudent.DataSource = students.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelStudent_Click(object sender, EventArgs e)
        {
            try
            {
                await(DataStudent.SelectedRows[0].DataBoundItem as Student)!.Delete();
                DataStudent.DataSource = students.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }








        private async void AddTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                await new Teacher
                {
                    Id = 0,
                    Familya = FamilTeh.Text,
                    Imiya = NameTeh.Text,
                    Otchestvo = OtchestvoTeh.Text,
                    UserId = UserIDTeh.SelectedValue as int?,
                    Phone = NumberPhoneTeh.Text,
                }.Add();
                Famil.Text = "";
                NameTeh.Text = "";
                OtchestvoTeh.Text = "";
                DataTeacher.DataSource = teachers.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataTeacher.SelectedRows[0].DataBoundItem is Teacher teacher)
                {
                    teacher.Familya = FamilTeh.Text;
                    teacher.Imiya = NameTeh.Text;
                    teacher.Otchestvo = OtchestvoTeh.Text;
                    teacher.UserId = UserIDTeh.SelectedValue as int?;
                    teacher.Phone = NumberPhoneTeh.Text;
                    await teacher.Update();
                }
                Famil.Text = "";
                NameTeh.Text = "";
                OtchestvoTeh.Text = "";
                DataTeacher.DataSource = teachers.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                await (DataTeacher.SelectedRows[0].DataBoundItem as Teacher)!.Delete();
                DataTeacher.DataSource = teachers.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        private async void AddUser_Click(object sender, EventArgs e)
        {
            var Pass = GetHash(Password.Text);
            await new User
            {
                Id = 0,
                Login = Login.Text,
                Password = Pass,
                RoleId = RoleID.SelectedValue as int?,
            }.Add();
            DataUser.DataSource = users.Objs;
        }

        private async void UpUser_Click(object sender, EventArgs e)
        {
            if (DataUser.SelectedRows[0].DataBoundItem is User user)
            {
                user.Login = Login.Text;
                user.Password = GetHash(Password.Text);
                user.RoleId = RoleID.SelectedValue as int?;
                await user.Update();
            }
            DataUser.DataSource = users.Objs;
        }

        private async void DelUser_Click(object sender, EventArgs e)
        {
            await (DataUser.SelectedRows[0].DataBoundItem as User)!.Delete();
            DataUser.DataSource = users.Objs;
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }



        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorisationForm autorisation = new AutorisationForm();
            autorisation.Show();
            this.Close();
        }

        private void фильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.userId = 0;
            TeacherExport teacher = new TeacherExport();
            teacher.Show();
            this.Hide();
        }
    }
}
