using System;
using System.Collections.Generic;
using VRising.Models.Enums;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;
using VRising.Models.RootModels;
using VRising.Models.UnitLocations.Models;

namespace VRising.Models.Gatherables
{
    public class GatherableModel : IModel
    {
        private readonly GatherableProperties _properties;

        public GatherableModel()
        {
            _properties = new GatherableProperties(this);
        }
        public int Id => GatherableId;
        public int Rarity { get; }
        public string Icon { get; }
        public string PrefabName { get; set; }
        public string BasePath { get; }

        public LocalizedResource LocalizedName => new(Guid.Empty.ToString(), PrefabNameCleaner.GetName(PrefabName));
        public RisingEntity Entity { get; set; }
        public int GatherableId { get; set; }

        public UnitCoords UnitCoords => Database.Current.UnitLocations.GetOrNull(GatherableId);


        public Dictionary<int, DropTriggerType> DropTables => _properties.DropTables.Value;

        //public Dictionary<int, List<string>> DropTableLocations => _properties.DropTableLocationsMap.Value;

        //public List<string> GetDropTableLocations(int dropTableId)
        //{
        //    return DropTableLocations.TryGetValue(dropTableId, out var dropTableLocations) ? dropTableLocations : new List<string>();
        //}
    }
}
