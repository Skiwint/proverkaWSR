using DiplomApp.AdminsPart;
using DiplomApp.Clasess;
using DiplomApp.Models;
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

namespace DiplomApp
{
    public partial class AutorisationForm : Form
    {
        AllModel<User> users = new AllModel<User>("Users");
        AllModel<Role> roles = new AllModel<Role>("Roles");
        AllModel<Student> students = new AllModel<Student>("Students");
        AllModel<Teacher> teachers = new AllModel<Teacher>("Teachers");

        public AutorisationForm()
        {
            InitializeComponent();
        }

        private void AutorisationForm_Load(object sender, EventArgs e)
        {

        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private async void SignIn_Click(object sender, EventArgs e)
        {
            SignIn.Enabled = false;
            var Pass = GetHash(PasswordText.Text);
            if (users.Objs.Any(user => user.Login == LoginText.Text && user.Password == Pass))
            {
                var user = users.Objs.FirstOrDefault(user => user.Login == LoginText.Text && user.Password == Pass)!;
                switch ((await new Role { Id = (int)user.RoleId! }.Get()).RoleName)
                {
                    case "Администратор":
                        AdminTabControl adminMenu = new AdminTabControl();
                        adminMenu.Show();
                        this.Hide();
                        break;


                    case "Студент":
                        StudentForm studentForm = new StudentForm(user.Id);
                        studentForm.Show();
                        this.Hide();
                        break;


                    case "Руководитель Орг.":
                        RykovodOrgForm rykovodOrg = new RykovodOrgForm(user.Id);
                        rykovodOrg.Show();
                        this.Hide();
                        break;


                    case "Руководитель техникумa":
                        TeacherForm teacher = new TeacherForm(user.Id);
                        teacher.Show();
                        this.Hide();
                        break;


                   
                    default:

                        return;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль, повторите попытку");
            }
            SignIn.Enabled = true;
        }

        private void RegFrm_Click(object sender, EventArgs e)
        {
          RegistrationForm registration = new RegistrationForm();
            registration.Show();
            this.Hide();
        }
    }
}
