using Newtonsoft.Json;
using VRising.Models.Items;
using VRising.Models.Npcs;
using VRising.Models.Quests;

namespace VRising.Models.Data
{
    public class UnlockSource
    {
        public int QuestId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }

        [JsonIgnore]
        public QuestModel Quest => Database.Current.Quests.ContainsKey(QuestId) ? Database.Current.Quests[QuestId] : null;

        [JsonIgnore]
        public ItemModel Item => Database.Current.Items.ContainsKey(ItemId) ? Database.Current.Items[ItemId] : null;

        [JsonIgnore]
        public NpcModel Npc => Database.Current.Npcs.ContainsKey(UnitId) ? Database.Current.Npcs[UnitId] : null;
    }
}
