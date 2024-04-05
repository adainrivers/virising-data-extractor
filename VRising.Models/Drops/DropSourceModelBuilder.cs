using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Data;
using VRising.Models.Enums;
using VRising.Models.Internal;

namespace VRising.Models.Drops
{
    internal class DropSourceModelBuilder
    {
        public DropSourceModel Build(RisingEntity entity)
        {
            var model = new DropSourceModel
            {
                Entity = entity,
                SourceId = entity.PrefabGuid,
                DropTables = entity.DropTableBuffer?.Select(b => new DropSourceDropTable
                {
                    DropTableId = b.DropTableGuid,
                    RelicType = Enum.Parse<RelicType>(b.RelicType.ToString()),
                    DropTrigger = Enum.Parse<DropTriggerType>(b.DropTrigger)
                }).ToList() ?? new List<DropSourceDropTable>()
            };

            if (Database.Current.Containers.TryGetValue(entity.PrefabGuid, out var container))
            {
                model.DropTables = container.DropTables.Select((dtkv) =>
                    new DropSourceDropTable
                    {
                        DropTableId = dtkv.Key,
                        RelicType = RelicType.None,
                        DropTrigger = dtkv.Value
                    }
                ).ToList();
            }

            if (Database.Current.Gatherables.TryGetValue(entity.PrefabGuid, out var gatherable))
            {
                model.DropTables = gatherable.DropTables.Select(dtkv =>
                    new DropSourceDropTable
                    {
                        DropTableId = dtkv.Key,
                        RelicType = RelicType.None,
                        DropTrigger = dtkv.Value
                    }
                ).ToList();
            }

            if (Database.Current.FishingSpots.TryGetValue(entity.PrefabGuid, out var fishingSpot))
            {
                model.DropTables = fishingSpot.DropTables.Select(dtkv =>
                    new DropSourceDropTable
                    {
                        DropTableId = dtkv.Key,
                        RelicType = RelicType.None,
                        DropTrigger = dtkv.Value
                    }
                ).ToList();
            }

            return model;
        }
    }
}