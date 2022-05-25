using DiplomApp.Clasess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Models
{
    public class Group: ModelAbstract
    {
        public Group()
        {

        }

        [JsonProperty("IdGroups")]
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Kyrs { get; set; }


        [JsonIgnore]
        public override string Path { get; set; } = "Groups";
    }
}
