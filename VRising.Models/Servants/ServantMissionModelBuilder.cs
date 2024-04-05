using System.Collections.Generic;
using System.Linq;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;

namespace VRising.Models.Servants
{
    internal class ServantMissionModelBuilder
    {
        public ServantMissionModel Build(RisingEntity entity)
        {
            var model = new ServantMissionModel
            {
                Entity = entity,
                ServantMissionId = entity.PrefabGuid,
                PrefabName = entity.PrefabName,
            };
            if (entity.MissionData != null)
            {
                model.ServantSlots = entity.MissionData.ServantSlots;
                model.Difficulty = entity.MissionData.MissionDifficulty;
            }
            if (entity.ManagedMissionData != null)
            {
                model.LocalizedName = new LocalizedResource(entity.ManagedMissionData.Name.Key,
                    entity.ManagedMissionData.Name.Text);

                model.LocalizedDescription = new LocalizedResource(entity.ManagedMissionData.Description.Key,
                    entity.ManagedMissionData.Description.Text);

                model.Icon = entity.ManagedMissionData.Icon;
            }

            model.Location = PrefabNameCleaner.GetName(model.PrefabName).Replace("Servant", string.Empty).Replace("Mission", string.Empty).Trim();

            model.ServantPerkIds = entity.PerksBuffer?.Select(b => b.Perk).ToHashSet() ?? new HashSet<int>();

            return model;
        }
    }
}