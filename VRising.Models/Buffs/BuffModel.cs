using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using VRising.Models.Enums;
using VRising.Models.Internal;
using VRising.Models.Localization;
using VRising.Models.RootModels;

namespace VRising.Models.Buffs
{
    public class BuffModel : ModelBase
    {
        public RisingEntity Entity { get; set; }


        public int BuffId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public BuffType BuffType { get; set; }

        public byte MaxStacks { get; set; }
        public bool PersistsThroughDeath { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public BuffCategories Category { get; set; }

        public int Level { get; set; }
        public bool KeepOldest { get; set; }
        public string PrefabName { get; set; }
        public HashSet<int> AbilityIds { get; set; }
        public LocalizedResource LocalizedDescription { get; set; }
    }
}