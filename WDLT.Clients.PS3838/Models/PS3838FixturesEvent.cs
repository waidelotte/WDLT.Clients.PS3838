using System;
using Newtonsoft.Json;
using WDLT.Clients.PS3838.Enums;

namespace WDLT.Clients.PS3838.Models
{
    public class PS3838FixturesEvent
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("starts")]
        public DateTimeOffset Starts { get; set; }

        [JsonProperty("home")]
        public string Home { get; set; }

        [JsonProperty("away")]
        public string Away { get; set; }

        [JsonProperty("rotNum")]
        public long RotNum { get; set; }

        [JsonProperty("liveStatus")]
        public EPS3838LiveStatus LiveStatus { get; set; }

        [JsonProperty("status")]
        public EPS3838EventStatus Status { get; set; }

        [JsonProperty("parlayRestriction")]
        public int ParlayRestriction { get; set; }

        [JsonProperty("altTeaser")]
        public bool AltTeaser { get; set; }

        [JsonProperty("resultingUnit")]
        public EPS3838Unit ResultingUnit { get; set; }

        [JsonProperty("betAcceptanceType")]
        public long BetAcceptanceType { get; set; }

        [JsonProperty("parentId")]
        public long? ParentId { get; set; }
    }
}