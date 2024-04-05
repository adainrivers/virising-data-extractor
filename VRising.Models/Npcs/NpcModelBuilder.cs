using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Data;
using VRising.Models.Enums;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;

namespace VRising.Models.Npcs
{
    internal class NpcModelBuilder
    {
        public NpcModel Build(RisingEntity entity)
        {
            var model = new NpcModel
            {
                Entity = entity,
                NpcId = entity.PrefabGuid,
                PrefabName = entity.PrefabName
            };

            if (entity.CharacterHUD != null)
            {
                model.LocalizedName = new LocalizedResource(entity.CharacterHUD.LocalizedName.Key,
                    entity.CharacterHUD.LocalizedName.Text);
                model.LocalizedDescription = new LocalizedResource(entity.CharacterHUD.LocalizedDesc.Key,
                    entity.CharacterHUD.LocalizedDesc.Text);
                model.EnemyColorTeamIndex = entity.CharacterHUD.EnemyColorTeamIndex;
                model.TeamType = Enum.Parse<TeamType>(entity.CharacterHUD.TeamType);
                model.PrefabType = Enum.Parse<PrefabType>(entity.CharacterHUD.PrefabType);
                model.BloodPrefabType = Enum.Parse<PrefabType>(entity.CharacterHUD.BloodPrefabType);
            }

            if (entity.VBloodPortraitData != null)
            {
                model.Icon = entity.VBloodPortraitData.HeadPortrait;
            }

            if (entity.EntityCategory != null)
            {
                model.UnitCategory = Enum.Parse<UnitCategory>(entity.EntityCategory.UnitCategory);
            }

            if (entity.Health != null)
            {
                model.Health = (float)entity.Health.MaxHealth;
            }

            if (entity.UnitLevel != null)
            {
                model.Level = entity.UnitLevel.Level;
            }

            //if (entity.ManagedCharacterHUD != null)
            //{
            //    model.Name = entity.ManagedCharacterHUD.Name.Text;
            //    model.Description = entity.ManagedCharacterHUD.Description.Text;
            //}

            if (entity.BloodConsumeSource != null)
            {
                model.BloodTypeId = entity.BloodConsumeSource.UnitBloodType;
                model.BloodCanBeConsumed = entity.BloodConsumeSource.CanBeConsumed;
            }

            if (entity.VBloodUnit != null)
            {
                model.VBloodNpc = true;
            }

            if (entity.UnitStats != null)
            {
                model.UnitStats = GenericMapper.Map<RisingDb_UnitStats, UnitStats>(entity.UnitStats);
            }

            if (entity.ResistanceData != null)
            {
                model.ResistanceData =
                    GenericMapper.Map<RisingDb_ResistanceData, ResistanceData>(entity.ResistanceData);
            }

            if (entity.ServantData == null)
            {
                model.AsServantId = entity.ServantConvertable?.ConvertToUnit;
            }
            else
            {
                model.IsServant = true;
            }

            model.FactionId = entity.FactionReference?.FactionGuid ?? 0;

            model.AbilityGroupIds = entity.AbilityGroupSlotBuffer?.Select(a => a.BaseAbilityGroupOnSlot).ToList() ?? new List<int>();

            model.MapInfo = MapInfo.FromUnit(model);

            foreach (var abilityGroupId in model.AbilityGroupIds)
            {
                if (!Database.Current.Mappings.AbilityGroupUnitMap.ContainsKey(abilityGroupId))
                {
                    Database.Current.Mappings.AbilityGroupUnitMap[abilityGroupId] = new HashSet<int>();
                }

                Database.Current.Mappings.AbilityGroupUnitMap[abilityGroupId].Add(model.NpcId);
            }

            if (entity.VBloodUnlockTechBuffer != null)
            {
                if (model.Id == 1106149033)
                {

                }

                var techEntities = entity.VBloodUnlockTechBuffer.Select(t => Database.Current.Entities[t.Guid]);
                model.TechUnlocks = TechUnlocks.FromTechEntities(techEntities);
                model.TechUnlocks.Register(model);
            }


            return model;
        }
    }
}