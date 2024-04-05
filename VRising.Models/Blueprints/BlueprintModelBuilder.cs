using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Data;
using VRising.Models.Enums;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;

namespace VRising.Models.Blueprints
{
    internal class BlueprintModelBuilder
    {
        public BlueprintModel Build(RisingEntity entity)
        {
            var model = new BlueprintModel
            {
                Entity = entity,
                BlueprintId = entity.PrefabGuid,
                PrefabName = entity.PrefabName,
            };

            if (entity.ManagedBlueprintData != null)
            {
                model.LocalizedName = new LocalizedResource(entity.ManagedBlueprintData.Name.Key,
                    entity.ManagedBlueprintData.Name.Text);
                model.LocalizedDescription = new LocalizedResource(
                    entity.ManagedBlueprintData.Description.Key.Key,
                    entity.ManagedBlueprintData.Description.Key.Text,
                    entity.LocalizedStringBuilderParameter?.ToDictionary(l => l.Key, l => l.Value)
                );
                model.Icon = entity.ManagedBlueprintData.Icon;
                model.Type = Enum.Parse<BlueprintType>(entity.ManagedBlueprintData.Type);
                model.LimitedType = Enum.Parse<CastleLimitedType>(entity.ManagedBlueprintData.LimitedType);
            }

            if (entity.BlueprintData != null)
            {
                model.IsStartBlueprint = entity.BlueprintData.IsStartBlueprint;
                model.IsInventoryItemBuilding = entity.BlueprintData.IsInventoryItemBuilding;
            }

            model.Requirements =
                entity.BlueprintRequirementBuffer
                    ?.Select(b => new ItemStacks { ItemGuidHash = b.PrefabGUID, Stacks = b.Stacks }).ToList() ??
                new List<ItemStacks>();

            if (entity.Health != null)
            {
                model.Health = (float)entity.Health.MaxHealth;
            }

            return model;
        }
    }
}