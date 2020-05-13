using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Models
{
   
    public class Crew
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("person")]
        public Person Person { get; set; }
    }

}
