using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.PS3838.Models
{
    public class PS3838FixturesResponse
    {
        [JsonProperty("sportId")]
        public long SportId { get; set; }

        [JsonProperty("last")]
        public long Last { get; set; }

        [JsonProperty("league")]
        public List<PS3838FixturesLeague> League { get; set; }
    }
}