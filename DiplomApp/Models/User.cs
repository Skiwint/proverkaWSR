using DiplomApp.Clasess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Models
{
    public partial class User : ModelAbstract
    {
        public User()
        {

        }
        [JsonProperty("IdUser")]
        public override int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int? RoleId
        {
            get => _roleId; set
            {
                _roleId = value;
                var role = new Role
                {
                    Id = (int)value!,
                }.GetNotAsync();
                RoleName = role.RoleName;
            }
        }


        [JsonIgnore]
        public string RoleName { get; set; }

        private int? _roleId;
        [JsonIgnore]
        public override string Path { get; set; } = "Users";

    }
}
