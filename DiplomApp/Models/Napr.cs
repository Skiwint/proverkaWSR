using DiplomApp.Clasess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Models
{
    public class Napr: ModelAbstract
    {
        public Napr()
        {

        }
        [JsonProperty("IdNapr")]
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Opisanye { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Naprs";
    }
}
