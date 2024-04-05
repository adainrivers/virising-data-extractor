using Newtonsoft.Json;
using VRising.Models.Buffs;

namespace VRising.Models.Data
{
    public class ItemSetBuff
    {
        public int ItemSetBuffId { get; set; }
        public int RequiredSetPieceCount { get; set; }

        [JsonIgnore]
        public BuffModel Buff => Database.Current.Buffs.ContainsKey(ItemSetBuffId)
            ? Database.Current.Buffs[ItemSetBuffId]
            : null;
    }
}