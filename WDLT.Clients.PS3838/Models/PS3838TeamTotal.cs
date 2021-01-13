using Newtonsoft.Json;

namespace WDLT.Clients.PS3838.Models
{
    public class PS3838TeamTotal
    {
        [JsonProperty("home")]
        public PS3838OverUnder Home { get; set; }

        [JsonProperty("away")]
        public PS3838OverUnder Away { get; set; }
    }
}