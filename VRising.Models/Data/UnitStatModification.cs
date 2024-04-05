using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using VRising.Models.Enums;
using VRising.Models.Localization;

namespace VRising.Models.Data
{
    public class UnitStatModification
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public UnitStatType StatType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ModificationType ModificationType { get; set; }

        public float Value { get; set; }
        public string Name { get; set; }
    }
}