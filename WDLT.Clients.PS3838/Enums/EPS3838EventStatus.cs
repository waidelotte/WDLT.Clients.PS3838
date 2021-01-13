using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.PS3838.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EPS3838EventStatus
    {
        [EnumMember(Value = "H")]
        Unavailable,
        [EnumMember(Value = "I")]
        RedCircle,
        [EnumMember(Value = "O")]
        Open,
    }
}