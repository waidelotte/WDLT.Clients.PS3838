using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.PS3838.Models
{
    public class PS3838FixturesLeague
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("events")]
        public List<PS3838FixturesEvent> Events { get; set; }
    }
}