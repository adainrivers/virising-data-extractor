using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Data;
using VRising.Models.Helpers;
using VRising.Models.Internal;

namespace VRising.Models.Items
{
    internal class ItemSetModelBuilder
    {
        public ItemSetModel Build(RisingEntity entity)
        {
            var model = new ItemSetModel
            {
                Entity = entity,
                ItemSetId = entity.PrefabGuid,
                PrefabName = entity.PrefabName,
                ItemGuids = entity.EquipmentSet?.Select(es => es.Item).ToHashSet() ?? new HashSet<int>(),
                NameKey = entity.EquipmentSet?.FirstOrDefault()?.SetName.Key.ToGuid() ?? Guid.Empty,
                Name = entity.EquipmentSet?.FirstOrDefault()?.SetName.Text,
                SetBonusses = entity.EquipmentSetElements?.Select(e => new ItemSetBuff
                {
                    ItemSetBuffId = e.Buff,
                    RequiredSetPieceCount = e.RequiredItemsInSet
                }).ToList() ?? new List<ItemSetBuff>()
            };

            return model;
        }
    }
}