using Newtonsoft.Json;
using WDLT.Clients.PS3838.Enums;

namespace WDLT.Clients.PS3838.Models
{
    public class PS3838Sport
    {
        [JsonProperty("id")]
        public EPS3838Sport Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hasOfferings")]
        public bool HasOfferings { get; set; }

        [JsonProperty("leagueSpecialsCount")]
        public int LeagueSpecialsCount { get; set; }

        [JsonProperty("eventSpecialsCount")]
        public int EventSpecialsCount { get; set; }

        [JsonProperty("eventCount")]
        public int EventCount { get; set; }
    }
}