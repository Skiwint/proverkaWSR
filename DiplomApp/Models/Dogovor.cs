using DiplomApp.Clasess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Models
{
    public class Dogovor: ModelAbstract
    {
        public Dogovor()
        {

        }
        [JsonProperty("IdDogovor")]
        public override int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreate { get; set; }
        public int? RykovodId
        {
            get => _rykovodId; set
            {
                _rykovodId = value;
                var rykovod = new Rykovod
                {
                    Id = (int)value!,
                }.GetNotAsync();
                RykovodName = rykovod.Familya;
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
        public int? PraktikId { get => _praktikId; set 
            { 
                _praktikId = value;
                var praktika = new Praktika
                {
                    Id= (int)value!,
                }.GetNotAsync();
                PraktikName = praktika.Name;
            } 
        } 

        [JsonIgnore]
        public string PraktikName { get; set; }
        private int? _praktikId;

        [JsonIgnore]
        public string RykovodName { get; set; }
        private int? _rykovodId;


        [JsonIgnore]
        public string StudentName { get; set; }
        private int? _studentId;

        [JsonIgnore]
        public override string Path { get; set; } = "Dogovors";
    }
}
