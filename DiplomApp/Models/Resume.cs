using DiplomApp.Clasess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Models
{
    public class Resume : ModelAbstract
    {
        public Resume()
        {

        }
        [JsonProperty("IdResume")]
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Opisanye { get; set; }
        public int? NaprId
        {
            get => _naprId; set
            {
                _naprId = value;
                var naprs = new Napr
                {
                    Id = (int)value!,
                }.GetNotAsync();
                NaprName = naprs.Name;
            }
        }
        public int? StudentsId
        {
            get => _studentId; set
            {

                _studentId = value;
                var students = new Student
                {
                    Id = (int)value!,
                }.GetNotAsync();
                StudentName = students.Familya;
            }
        }



        [JsonIgnore]
        public string NaprName { get; set; }
        [JsonIgnore]
        public string StudentName { get; set; }

        private int? _naprId;
        private int? _studentId;

        [JsonIgnore]
        public override string Path { get; set; } = "Resumes";
    }
}
