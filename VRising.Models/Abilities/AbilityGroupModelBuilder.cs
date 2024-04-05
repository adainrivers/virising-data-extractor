using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Data;
using VRising.Models.Enums;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;

namespace VRising.Models.Abilities
{
    internal class AbilityGroupModelBuilder
    {
        public AbilityGroupModel Build(RisingEntity entity)
        {
            var model = new AbilityGroupModel
            {
                Entity = entity,
                AbilityGroupId = entity.PrefabGuid,
                PrefabName = entity.PrefabName
            };

            if (entity.ManagedAbilityGroupData != null)
            {
                model.LocalizedName = new LocalizedResource(entity.ManagedAbilityGroupData.Name.Key,
                    entity.ManagedAbilityGroupData.Name.Text);
                model.Icon = entity.ManagedAbilityGroupData.Icon;
            }

            model.IsAbilityGroup = entity.AbilityGroupState != null;

            if (model.LocalizedName?.Text == "No Name")
            {
                model.LocalizedName = new LocalizedResource(Guid.Empty.ToString(),
                    PrefabNameCleaner.GetName(model.PrefabName) ?? model.PrefabName);
            }


            if (entity.AbilityTooltipData != null)
            {
                model.LocalizedDescription = new LocalizedResource(
                    entity.AbilityTooltipData.Description.Key.Key,
                    entity.AbilityTooltipData.Description.Key.Text,
                    entity.LocalizedStringBuilderParameter?.ToDictionary(l => l.Key, l => l.Value));
                model.ToolTipType = Enum.Parse<AbilityTooltipType>(entity.AbilityTooltipData.TooltipType);
            }

            model.ConsumableItemId = entity.AbilityGroupConsumeItemOnCast?.ConsumableId;
            model.MaxCharges = entity.AbilityChargesData?.MaxCharges;
            model.IgnoreCooldownModifier = entity.AbilityChargesData?.IgnoreCooldownModifier;
            model.ChargeUpTime = entity.AbilityChargesData?.ChargeUpTime;

            model.MaxCooldown = entity.AbilityCooldownData?.MaxCooldown;
            model.MaxCastTime = entity.AbilityCastTimeData?.MaxCastTime;
            model.HideCastBar = entity.AbilityCastTimeData?.HideCastBar;
            model.PostCastTime = entity.AbilityCastTimeData?.PostCastTime;
            model.TotalCastTime = entity.AbilityCastTimeData?.TotalCastTime;

            model.AbilityCastConditions = entity.AbilityCastCondition?.Select(c => new AbilityCastConditionModel
            {
                ConditionId = c.ConditionId,
                FailureTextGuid = c.FailKey.Key.ToGuid(),
                FailureText = c.FailKey.ToString()
            }).ToList() ?? new List<AbilityCastConditionModel>();

            model.AbilityIds = entity.AbilityGroupStartAbilitiesBuffer?.Select(a => a.PrefabGUID).ToList() ??
                               new List<int>();

            if (entity.VBloodAbilityData != null)
            {
                model.AbilityType = Enum.Parse<AbilityTypeEnum>(entity.VBloodAbilityData.AbilityType);
                model.AbilitySchool =
                    Enum.Parse<AbilitySchoolType>(entity.VBloodAbilityData.AbilitySchool);
            }

            if (entity.VBloodShapeshiftData != null)
            {
                model.AbilitySchool = AbilitySchoolType.Shapeshift;
            }

            return model;
        }
    }


}