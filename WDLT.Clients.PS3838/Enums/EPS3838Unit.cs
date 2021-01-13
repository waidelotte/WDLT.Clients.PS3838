﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.PS3838.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EPS3838Unit
    {
        Bookings,
        Corners,
        Regular,
        Kills
    }
}