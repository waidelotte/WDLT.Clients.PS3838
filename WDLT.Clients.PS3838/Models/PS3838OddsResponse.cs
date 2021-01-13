using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.PS3838.Models
{
    public class PS3838OddsResponse
    {
        [JsonProperty("sportId")]
        public long SportId { get; set; }

        [JsonProperty("last")]
        public long Last { get; set; }

        [JsonProperty("leagues")]
        public List<PS3838OddsLeague> Leagues { get; set; }
    }
}