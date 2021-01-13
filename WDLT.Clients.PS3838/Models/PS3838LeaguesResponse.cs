using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.PS3838.Models
{
    public class PS3838LeaguesResponse
    {
        [JsonProperty("league")]
        public List<PS3838League> Leagues { get; set; }
    }
}