using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Constants;
using VRising.Models.Enums;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;

namespace VRising.Models.Stations
{
    internal class WorkstationModelBuilder
    {
        public WorkstationModel Build(RisingEntity entity)
        {
            var model = new WorkstationModel
            {
                Entity = entity,
                WorkstationId = entity.PrefabGuid,
                PrefabName = entity.PrefabName
            };

            if (model.WorkstationId == KnownEntities.User)
            {
                model.LocalizedName = new LocalizedResource(Guid.Empty.ToString(), "Inventory Crafting Tab");
                model.LocalizedDescription = new LocalizedResource(Guid.Empty.ToString(), "Player's crafting tab");

                model.WorkstationType = WorkstationType.Player;
            }
            else

            if (entity.ManagedCharacterHUD != null)
            {
                model.LocalizedName = new LocalizedResource(entity.ManagedCharacterHUD.Name.Key,
                    entity.ManagedCharacterHUD.Name.Text);
                model.LocalizedDescription = new LocalizedResource(entity.ManagedCharacterHUD.Description.Key,
                    entity.ManagedCharacterHUD.Description.Text);
                model.WorkstationType = WorkstationType.Trader;
                model.Icon = entity.ManagedCharacterHUD.Icon;
            }

            if (entity.Workstation == true)
            {
                if (model.PrefabName.Contains("Trader"))
                {
                    model.WorkstationType = WorkstationType.Trader;
                }
                else
                {
                    model.WorkstationType = WorkstationType.Workstation;
                }
            }

            if (entity.Refinementstation != null)
            {
                model.WorkstationType = WorkstationType.RefinementStation;
            }

            if (entity.UnitSpawnerstation != null)
            {
                model.WorkstationType = WorkstationType.UnitSpawner;
            }

            if (entity.ManagedBlueprintData != null)
            {
                model.LocalizedName = new LocalizedResource(entity.ManagedBlueprintData.Name.Key,
                    entity.ManagedBlueprintData.Name.Text);
                model.LocalizedDescription = new LocalizedResource(entity.ManagedBlueprintData.Description.Key.Key,
                    entity.ManagedBlueprintData.Description.Key.Text);

                model.Icon = entity.ManagedBlueprintData.Icon;
            }

            if (entity.StationServants != null)
            {
                model.StationServantTypes = Enum.Parse<ServantType>(entity.StationServants.Servants);
            }

            if (entity.CastleWorkstation != null)
            {
                model.MatchingFloorType = Enum.Parse<CastleFloorTypes>(entity.CastleWorkstation.MatchingFloorType);
                model.BonusServantType = Enum.Parse<ServantType>(entity.CastleWorkstation.BonusServantType);
                model.WorkstationLevel = Enum.Parse<WorkstationLevel>(entity.CastleWorkstation.WorkstationLevel);
            }

            model.StationBonusIds = entity.StationBonusBuffer?.Select(sb => sb.StationBonusGuid).ToHashSet() ??
                                    new HashSet<int>();

            model.WorkstationRecipeIds = entity.WorkstationRecipesBuffer?.Select(wr => wr.RecipeGuid).ToHashSet() ??
                                         new HashSet<int>();
            model.RefinementRecipeIds = entity.RefinementstationRecipesBuffer?.Select(wr => wr.RecipeGuid).ToHashSet() ??
                                        new HashSet<int>();

            //if (entity.Buff != null)
            //{
            //    model.BuffType = Enum.Parse<BuffType>(entity.Buff.BuffType);
            //    model.MaxStacks = (byte)entity.Buff.MaxStacks;
            //}

            //if (entity.Description != null)
            //{
            //    model.DescriptionKey = entity.Description.DescriptionId.Key.Key.ToGuid();
            //    model.Description =
            //        entity.Description.DescriptionId.Key.Text.BuildDescription(entity.LocalizedStringBuilderParameter);
            //}

            //if (entity.BuffCategory != null)
            //{
            //    model.Category = Enum.Parse<BuffCategories>(entity.BuffCategory.Groups);
            //    model.Level = entity.BuffCategory.Level;
            //    model.KeepOldest = entity.BuffCategory.KeepOldest;
            //}

            return model;
        }
    }
}