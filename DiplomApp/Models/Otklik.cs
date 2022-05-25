using DiplomApp.Clasess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Models
{
    public partial class Otklik : ModelAbstract
    {
        public Otklik()
        {

        }
        [JsonProperty("IdOtlik")]
        public override int Id { get; set; }
        public string Tema { get; set; }
        public string Opisanie { get; set; }
        public string status { get; set; }
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
        public int? PredlojenyeId
        {
            get => _predlojId; set
            {
                _predlojId = value;
                var predlj = new Predlojenye
                {
                    Id = (int)value!,
                }.GetNotAsync();
                PredlName = predlj.Tema;
            }
        }


        [JsonIgnore]
        public string PredlName { get; set; }
        [JsonIgnore]
        public string StudentName { get; set; }


        private int? _studentId;
        private int? _predlojId;
        [JsonIgnore]
        public override string Path { get; set; } = "Otkliks";
    }
}
