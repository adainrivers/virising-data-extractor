using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Data;
using VRising.Models.Enums;
using VRising.Models.Helpers;
using VRising.Models.Internal;

namespace VRising.Models.Drops
{
    internal class DropGroupModelBuilder
    {
        public DropGroupModel Build(RisingEntity entity)
        {
            var model = new DropGroupModel
            {
                Entity = entity,
                DropGroupId = entity.PrefabGuid,
                PrefabName = entity.PrefabName,
                Name = PrefabNameCleaner.GetName(entity.PrefabName),
                Entries = entity.ItemDataDropGroupBuffer?.Select(b => new DropGroupEntry
                {
                    EntryEntityId = b.DropItemPrefab,
                    DropItemType = Enum.Parse<DropItemType>(b.Type),
                    Quantity = b.Quantity,
                    Weight = b.Weight
                }).ToList() ?? new List<DropGroupEntry>()
            };

            var totalEntryWeight = model.Entries.Sum(e => e.Weight);
            if (totalEntryWeight > 0)
            {
                foreach (var entry in model.Entries)
                {
                    entry.DropRate = (float)entry.Weight / totalEntryWeight;
                }
            }

            return model;
        }
    }
}