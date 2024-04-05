using System;
using System.Collections.Generic;
using VRising.Models.Enums;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;
using VRising.Models.RootModels;
using VRising.Models.UnitLocations.Models;

namespace VRising.Models.Fishing
{
    public class FishingSpotModel : IModel
    {
        private readonly FishingSpotProperties _properties;

        public FishingSpotModel()
        {
            _properties = new FishingSpotProperties(this);
        }
        public int Id => FishingSpotId;
        public int Rarity { get; }
        public string Icon { get; }
        public string PrefabName { get; set; }
        public string BasePath { get; }

        public LocalizedResource LocalizedName { get; set; }
        public RisingEntity Entity { get; set; }
        public int FishingSpotId { get; set; }

        public UnitCoords UnitCoords => Database.Current.UnitLocations.GetOrNull(FishingSpotId);


        public Dictionary<int, DropTriggerType> DropTables => _properties.DropTables.Value;

        //public Dictionary<int, List<string>> DropTableLocations => _properties.DropTableLocationsMap.Value;

        //public List<string> GetDropTableLocations(int dropTableId)
        //{
        //    return DropTableLocations.TryGetValue(dropTableId, out var dropTableLocations) ? dropTableLocations : new List<string>();
        //}
    }
}
