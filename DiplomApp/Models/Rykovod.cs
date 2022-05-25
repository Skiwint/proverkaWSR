using DiplomApp.Clasess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Models
{
    public partial class Rykovod : ModelAbstract
    {
        public Rykovod()
        {

        }
        [JsonProperty("IdRykovod")]
        public override int Id { get; set; }
        public string Familya { get; set; }
        public string Imiya { get; set; }
        public string Otchestvo { get; set; }
        public string Doljnost { get; set; }
        public string Phone { get; set; }
        public int? UserId
        {
            get => _userId; set
            {
                _userId = value;
                var user = new User
                {
                    Id = (int)value!,
                }.GetNotAsync();
                UserName = user.Login;
            }
        }
        public int? OrgId
        {
            get => _orgId; set
            {
                _orgId = value;
                var org = new Organization
                {
                    Id = (int)value!,
                }.GetNotAsync();
                OrgName = org.Name;
            }
        }

        [JsonIgnore]
        public string UserName { get; set; }

        private int? _userId;

        [JsonIgnore]
        public string OrgName { get; set; }

        private int? _orgId;
        [JsonIgnore]
        public override string Path { get; set; } = "Rykovods";

    }
}
