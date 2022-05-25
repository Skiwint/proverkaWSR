using DiplomApp.Clasess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Models
{
    public class Organization : ModelAbstract
    {
        public Organization()
        {

        }
        [JsonProperty("IdOrg")]
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Opisanye { get; set; }
        public string INN { get; set; }
        [JsonIgnore]
        public string NaprName { get; set; }

        public int? NaprId
        {
            get => _naprId; set
            {
                _naprId = value;
                var oblast = new Napr
                {
                    Id = (int)value!,
                }.GetNotAsync();
                NaprName = oblast.Name;
            }
        }

        

        private int? _naprId;

        [JsonIgnore]
        public override string Path { get; set; } = "Organizations";
    }
}
