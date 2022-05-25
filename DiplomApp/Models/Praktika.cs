using DiplomApp.Clasess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Models
{
    public class Praktika : ModelAbstract
    {
        public Praktika()
        {

        }

        [JsonProperty("IdPraktik")]
        public override int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }


        [JsonIgnore]
        public override string Path { get; set; } = "Praktikas";
    }
}
