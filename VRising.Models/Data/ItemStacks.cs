using Newtonsoft.Json;
using VRising.Models.Items;

namespace VRising.Models.Data
{
    public class ItemStacks
    {
        public int ItemGuidHash { get; set; }
        public int Stacks { get; set; }

        [JsonIgnore]
        public ItemModel Item => Database.Current.Items.ContainsKey(ItemGuidHash)
            ? Database.Current.Items[ItemGuidHash]
            : null;
    }
}