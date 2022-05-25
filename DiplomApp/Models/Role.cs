﻿using DiplomApp.Clasess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Models
{
    public partial class Role : ModelAbstract
    {
        public Role()
        {

        }
        [JsonProperty("IdRole")]
        public override int Id { get; set; }
        public string RoleName { get; set; }


        
        [JsonIgnore]
        public override string Path { get; set; } = "Roles";
    }
}
