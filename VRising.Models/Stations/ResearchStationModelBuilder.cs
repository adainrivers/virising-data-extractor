using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Enums;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;

namespace VRising.Models.Stations
{
    internal class ResearchStationModelBuilder
    {
        public ResearchStationModel Build(RisingEntity entity)
        {
            var model = new ResearchStationModel
            {
                Entity = entity,
                ResearchStationId = entity.PrefabGuid,
                PrefabName = entity.PrefabName
            };



            if (entity.ResearchStation != null)
            {
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

            model.ResearchIds = entity.ResearchBuffer?.Select(wr => wr.ResearchGuid).ToHashSet() ??
                                         new HashSet<int>();

            return model;
        }
    }
}