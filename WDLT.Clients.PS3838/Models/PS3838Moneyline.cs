using Newtonsoft.Json;

namespace WDLT.Clients.PS3838.Models
{
    public class PS3838Moneyline
    {
        [JsonProperty("home")]
        public double Home { get; set; }

        [JsonProperty("away")]
        public double Away { get; set; }

        [JsonProperty("draw")]
        public double? Draw { get; set; }
    }
}