using DiplomApp.Clasess;
using Newtonsoft.Json;

namespace DiplomApp.Models
{
    public partial class Student : ModelAbstract
    {
        public Student()
        {

        }
        [JsonProperty("IdStudents")]
        public override int Id { get; set; }
        public string Familya { get; set; }
        public string Imiya { get; set; }
        public string Otchestvo { get; set; }
        public string Phone { get; set; }
        public int? GroupsId
        {
            get => _groupId; set
            {
                _groupId = value;
                var group = new Group
                {
                    Id = (int)value!,
                }.GetNotAsync();
                GroupName = group.Name;
            }
        }
        public int? UserId { get => _userId; set 
            {
                _userId = value;
                var user = new User
                {
                    Id = (int)value!,
                }.GetNotAsync();
                UserName = user.Login;
            }
        }
        public int? TeachId
        {
            get => _teachId; set
            {
                _teachId = value;
                var teacher = new Teacher
                {
                    Id = (int)value!
                }.GetNotAsync();
                TeachFio = teacher.Familya;
            }
        }

        [JsonIgnore]
        public string GroupName { get; set; }

        [JsonIgnore]
        public string UserName { get; set; }
        
        [JsonIgnore]
        public string TeachFio { get; set; }

        private int? _teachId;
        private int? _userId;
        private int? _groupId;

        [JsonIgnore]
        public override string Path { get; set; } = "Students";

    }
}
