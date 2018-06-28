using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWarsAPI
{
    public class CharacterNameOutput
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}