using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.PS3838.Models
{
    public class PS3838Period
    {
        [JsonProperty("lineId")]
        public long LineId { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("cutoff")]
        public DateTimeOffset Cutoff { get; set; }

        [JsonProperty("spreadUpdatedAt")]
        public DateTimeOffset? SpreadUpdatedAt { get; set; }

        [JsonProperty("moneylineUpdatedAt")]
        public DateTimeOffset? MoneylineUpdatedAt { get; set; }

        [JsonProperty("totalUpdatedAt")]
        public DateTimeOffset? TotalUpdatedAt { get; set; }

        [JsonProperty("teamTotalUpdatedAt")]
        public DateTimeOffset? TeamTotalUpdatedAt { get; set; }

        [JsonProperty("maxSpread")]
        public double? MaxSpread { get; set; }

        [JsonProperty("maxMoneyline")]
        public double? MaxMoneyline { get; set; }

        [JsonProperty("maxTotal")]
        public double? MaxTotal { get; set; }

        [JsonProperty("maxTeamTotal")]
        public double? MaxTeamTotal { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("spreads")]
        public List<PS3838Spread> Spreads { get; set; }

        [JsonProperty("moneyline")]
        public PS3838Moneyline Moneyline { get; set; }

        [JsonProperty("totals")]
        public List<PS3838OverUnder> Totals { get; set; }

        [JsonProperty("teamTotal")]
        public PS3838TeamTotal TeamTotal { get; set; }
    }
}