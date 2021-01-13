using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.PS3838.Models
{
    public class PS383SportsResponse
    {
        [JsonProperty("sports")]
        public List<PS3838Sport> Sports { get; set; }
    }
}