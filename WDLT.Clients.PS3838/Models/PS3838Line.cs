using Newtonsoft.Json;
using WDLT.Clients.PS3838.Enums;

namespace WDLT.Clients.PS3838.Models
{
    public class PS3838Line
    {
        [JsonProperty("status")]
        public EPS3838LineStatus Status { get; set; }

        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("lineId")]
        public long? LineId { get; set; }

        [JsonProperty("altLineId")]
        public long? AltLineId { get; set; }

        [JsonProperty("team1Score")]
        public int? Team1Score { get; set; }

        [JsonProperty("team2Score")]
        public int? Team2Score { get; set; }

        [JsonProperty("team1RedCards")]
        public int? Team1RedCards { get; set; }

        [JsonProperty("team2RedCards")]
        public int? Team2RedCards { get; set; }

        [JsonProperty("maxRiskStake")]
        public double? MaxRiskStake { get; set; }

        [JsonProperty("minRiskStake")]
        public double? MinRiskStake { get; set; }

        [JsonProperty("maxWinStake")]
        public double? MaxWinStake { get; set; }

        [JsonProperty("minWinStake")]
        public double? MinWinStake { get; set; }

        [JsonProperty("effectiveAsOf")]
        public string EffectiveAsOf { get; set; }
    }
}