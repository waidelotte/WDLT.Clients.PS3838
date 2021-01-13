using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.PS3838.Models
{
    public class PS3838OddsEvent
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("periods")]
        public List<PS3838Period> Periods { get; set; }

        [JsonProperty("awayScore")]
        public int? AwayScore { get; set; }

        [JsonProperty("homeScore")]
        public int? HomeScore { get; set; }

        [JsonProperty("awayRedCards")]
        public int? AwayRedCards { get; set; }

        [JsonProperty("homeRedCards")]
        public int? HomeRedCards { get; set; }
    }
}