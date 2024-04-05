using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Data;
using VRising.Models.Enums;
using VRising.Models.Internal;
using VRising.Models.Localization;
using VRising.Models.Recipes;

namespace VRising.Models.Items
{
    internal class ItemModelBuilder
    {
        public ItemModel Build(RisingEntity entity)
        {
            var model = new ItemModel
            {
                Entity = entity,
                ItemId = entity.PrefabGuid,
                PrefabName = entity.PrefabName
            };

            if (entity.ItemData != null)
            {
                model.BloodBound = entity.ItemData.BloodBound;
                model.ItemCategory = Enum.Parse<ItemCategory>(entity.ItemData.ItemCategory);
                model.ItemType = Enum.Parse<ItemType>(entity.ItemData.ItemType);
                model.MaxStacks = entity.ItemData.MaxStacks;
                model.RemoveOnConsume = entity.ItemData.RemoveOnConsume;
                model.SilverValue = (float)entity.ItemData.SilverValue;
                model.SoulBound = entity.ItemData.SoulBound;
            }

            model.ConsumableAbilityId = entity.CastAbilityOnConsume?.AbilityGuid ?? 0;
            model.VBloodSourceUnitId = entity.VBloodItemSource?.VBloodUnit ?? 0;


            if (entity.ManagedItemData != null)
            {
                model.LocalizedName =
                    new LocalizedResource(entity.ManagedItemData.Name.Key, entity.ManagedItemData.Name.Text);

                model.LocalizedDescription = new LocalizedResource(entity.ManagedItemData.Description.Key.Key,
                    entity.ManagedItemData.Description.Key.Text,
                    entity.LocalizedStringBuilderParameter?.ToDictionary(s => s.Key, s => s.Value));
                model.Icon = entity.ManagedItemData.Icon;
            }

            if (model.ItemType == ItemType.Equippable && entity.EquippableData != null)
            {
                model.EquipmentType = Enum.Parse<EquipmentType>(entity.EquippableData.EquipmentType);
                model.WeaponType = Enum.Parse<WeaponType>(entity.EquippableData.WeaponType);
                model.EquipmentSetGuidHash = entity.EquippableData.EquipmentSet;
                model.EquipmentBuffGuidHash = entity.EquippableData.BuffGuid;
            }
            else
            {
                model.EquipmentType = EquipmentType.None;
                model.WeaponType = WeaponType.None;
            }

            model.ArmorLevelSource = entity.ArmorLevelSource != null ? (float)entity.ArmorLevelSource.Level : 0;
            model.WeaponLevelSource = entity.WeaponLevelSource != null ? (float)entity.WeaponLevelSource.Level : 0;
            model.SpellLevelSource = entity.SpellLevelSource != null ? (float)entity.SpellLevelSource.Level : 0;
            model.SalvageFactor = entity.Salvageable != null ? (float)entity.Salvageable.SalvageFactor : 0;
            model.SalvageTimer = entity.Salvageable != null ? (float)entity.Salvageable.SalvageTimer : 0;
            model.SalvageRecipeGuidHash = entity.Salvageable?.RecipeGUID ?? 0;
            model.Salvageable = entity.Salvageable != null;

            if (model.Salvageable && model.SalvageRecipeGuidHash == 0)
            {
                model.SalvageFactor = 1;
            }

            if (model.Salvageable && entity.RecipeRequirementBuffer != null)
            {
                model.FakeSalvageRecipe = new RecipeModel
                {
                    Requirements = entity.RecipeRequirementBuffer
                        .Select(r => new ItemStacks { ItemGuidHash = r.Guid, Stacks = r.Stacks }).ToList()
                };
            }

            if (entity.Durability != null)
            {
                model.MaxDurability = (float)entity.Durability.MaxDurability;
                model.RepairRecipeGuidHash = entity.Durability.RepairRecipe;
                model.RepairOneLevelFactor = (float)entity.Durability.OneLevelFactor;
                model.RepairTwoLevelFactor = (float)entity.Durability.TwoLevelFactor;
                model.RepairThreeLevelFactor = (float)entity.Durability.ThreeLevelFactor;
            }


            model.UnitStatModifications = entity.ModifyUnitStatBuff_DOTS?.Select(m => new UnitStatModification
            {
                StatType = Enum.Parse<UnitStatType>(m.StatType),
                ModificationType = Enum.Parse<ModificationType>(m.ModificationType),
                Value = (float)m.Value,
                Name = m.Name
            }).ToList() ?? new List<UnitStatModification>();

            if (model.ItemId == -706178162)
            {

            }

            if (Database.Current.Mappings.TechItemTechMap.Contains(model.ItemId))
            {
                var techEntities = Database.Current.Mappings.TechItemTechMap[model.ItemId].Distinct().Select(t => Database.Current.Entities[t]).ToList();

                model.TechUnlocks = TechUnlocks.FromTechEntities(techEntities);
                model.TechUnlocks.Register(model);
            }

            model.MapInfo = MapInfo.FromItem(model);
            return model;
        }
    }
}