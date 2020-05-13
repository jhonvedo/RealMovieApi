using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Models
{
    public class Aka
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }
    }

}
