using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gnosys.Models

{
        public class Root
        {
            [JsonProperty("@context")]
            public string Context { get; set; }

            [JsonProperty("@id")]
            public string Id { get; set; }

            [JsonProperty("@type")]
            public string Type { get; set; }

            [JsonProperty("hydra:member")]
            public List<HydraMember> HydraMember { get; set; }

            [JsonProperty("hydra:totalItems")]
            public int HydraTotalItems { get; set; }
        }
   
}
