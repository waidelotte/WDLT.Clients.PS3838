using Newtonsoft.Json;

namespace WDLT.Clients.PS3838.Models
{
    public class PS3838Spread
    {
        [JsonProperty("hdp")]
        public double Hdp { get; set; }

        [JsonProperty("home")]
        public double Home { get; set; }

        [JsonProperty("away")]
        public double Away { get; set; }

        [JsonProperty("altLineId")]
        public long? AltLineId { get; set; }
    }
}