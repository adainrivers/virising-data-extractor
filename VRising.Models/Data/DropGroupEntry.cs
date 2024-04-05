using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using VRising.Models.Drops;
using VRising.Models.Enums;
using VRising.Models.Items;
using VRising.Models.Npcs;

namespace VRising.Models.Data
{
    public class DropGroupEntry
    {
        public int EntryEntityId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public DropItemType DropItemType { get; set; }

        public int Quantity { get; set; }
        public int Weight { get; set; }
        public float DropRate { get; set; }

        [JsonIgnore]
        public DropGroupModel DropGroup => DropItemType != DropItemType.Group ? null :
            !Database.Current.DropGroups.ContainsKey(EntryEntityId) ? null :
            Database.Current.DropGroups[EntryEntityId];

        [JsonIgnore]
        public ItemModel Item => DropItemType != DropItemType.Item ? null :
            !Database.Current.Items.ContainsKey(EntryEntityId) ? null :
            Database.Current.Items[EntryEntityId];

        [JsonIgnore]
        public NpcModel Npc => DropItemType != DropItemType.Unit ? null :
            !Database.Current.Npcs.ContainsKey(EntryEntityId) ? null :
            Database.Current.Npcs[EntryEntityId];

        public float CalculateDropRate(int totalWeight)
        {
            return (float)Weight / totalWeight;
        }
    }
}