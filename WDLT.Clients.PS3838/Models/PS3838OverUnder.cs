using Newtonsoft.Json;

namespace WDLT.Clients.PS3838.Models
{
    public class PS3838OverUnder
    {
        [JsonProperty("points")]
        public double Points { get; set; }

        [JsonProperty("over")]
        public double Over { get; set; }

        [JsonProperty("under")]
        public double Under { get; set; }

        [JsonProperty("altLineId")]
        public long? AltLineId { get; set; }
    }
}