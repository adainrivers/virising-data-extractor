using System.Collections.Generic;
using System.Linq;
using VRising.Models.Data;
using VRising.Models.Internal;

namespace VRising.Models.Recipes
{
    internal class RecipeModelBuilder
    {
        public RecipeModel Build(RisingEntity entity)
        {
            var model = new RecipeModel
            {
                Entity = entity,
                RecipeId = entity.PrefabGuid,
                PrefabName = entity.PrefabName,
            };

            if (entity.RecipeData != null)
            {
                model.CraftDuration = (float)entity.RecipeData.CraftDuration;
                model.AlwaysUnlocked = entity.RecipeData.AlwaysUnlocked;
                model.HudSortingOrder = entity.RecipeData.HudSortingOrder;
                model.IgnoreServerSettings = entity.RecipeData.IgnoreServerSettings;
            }


            model.RepairCosts =
                entity.ItemRepairBuffer?.Select(r => new ItemStacks { ItemGuidHash = r.Guid, Stacks = r.Stacks })
                    .ToList() ?? new List<ItemStacks>();
            model.Requirements =
                entity.RecipeRequirementBuffer?.Select(r => new ItemStacks { ItemGuidHash = r.Guid, Stacks = r.Stacks })
                    .ToList() ?? new List<ItemStacks>();
            model.Outputs =
                entity.RecipeOutputBuffer?.Select(r => new ItemStacks { ItemGuidHash = r.Guid, Stacks = r.Stacks })
                    .ToList() ?? new List<ItemStacks>();
            model.OutputUnits =
                entity.RecipeOutputUnitBuffer?.Select(r => new ItemStacks { ItemGuidHash = r.Guid, Stacks = r.Stacks })
                    .ToList() ?? new List<ItemStacks>();

            return model;
        }
    }
}