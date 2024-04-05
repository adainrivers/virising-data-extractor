using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VRising.Models.Items;

namespace VRising.Models.Data
{
    public class ItemDropChance
    {
        public ItemDropChance(int itemId, float dropChance, int quantity)
        {
            ItemId = itemId;
            DropChance = dropChance;
            Quantity = quantity;
        }

        public int ItemId { get; }
        public float DropChance { get; }
        public int Quantity { get; }

        [JsonIgnore]
        public ItemModel Item => Database.Current.Items.ContainsKey(ItemId)
            ? Database.Current.Items[ItemId]
            : null;
    }

    public class ItemDropChanceComparer : IEqualityComparer<ItemDropChance>
    {
        public bool Equals(ItemDropChance x, ItemDropChance y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }

            if (ReferenceEquals(x, null))
            {
                return false;
            }

            if (ReferenceEquals(y, null))
            {
                return false;
            }

            if (x.GetType() != y.GetType())
            {
                return false;
            }

            var equals = x.ItemId == y.ItemId && Math.Abs(x.DropChance - y.DropChance) < 0.00001 &&
                         x.Quantity == y.Quantity;

            if (equals)
            {
            }

            return equals;
        }

        public int GetHashCode(ItemDropChance obj)
        {
            return HashCode.Combine(obj.ItemId, obj.DropChance, obj.Quantity);
        }
    }
}