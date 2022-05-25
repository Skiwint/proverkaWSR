using DiplomApp.Clasess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Models
{
    public class Predlojenye : ModelAbstract
    {
        public Predlojenye()
        {

        }
        [JsonProperty("IdPredlojenye")]
        public override int Id { get; set; }
        public string Tema { get; set; }
        public string Opisanie { get; set; }
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


        [JsonIgnore]
        public string RykovodName { get; set; }


        private int? _rykovodId;
        
        
        [JsonIgnore]
        public override string Path { get; set; } = "Predlojenyes";
    }
}
