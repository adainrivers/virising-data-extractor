using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Enums;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;

namespace VRising.Models.Buffs
{
    internal class BuffModelBuilder
    {
        public BuffModel Build(RisingEntity entity)
        {
            var model = new BuffModel
            {
                Entity = entity,
                BuffId = entity.PrefabGuid,
                PrefabName = entity.PrefabName
            };

            if (entity.Buff != null)
            {
                model.BuffType = Enum.Parse<BuffType>(entity.Buff.BuffType);
                model.MaxStacks = (byte)entity.Buff.MaxStacks;
            }

            if (entity.Description != null)
            {
                model.LocalizedDescription = new LocalizedResource(entity.Description.DescriptionId.Key.Key,
                    entity.Description.DescriptionId.Key.Text,
                    entity.LocalizedStringBuilderParameter?.ToDictionarySafe(l => l.Key, l => l.Value));
            }

            if (entity.BuffCategory != null)
            {
                model.Category = Enum.Parse<BuffCategories>(entity.BuffCategory.Groups);
                model.Level = entity.BuffCategory.Level;
                model.KeepOldest = entity.BuffCategory.KeepOldest;
            }

            model.AbilityIds = entity.ReplaceAbilityOnSlotBuff?.Select(a => a.NewGroupId).ToHashSet() ??
                               new HashSet<int>();

            return model;
        }
    }
}