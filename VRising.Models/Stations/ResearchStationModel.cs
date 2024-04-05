using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VRising.Localization;
using VRising.Models.Blueprints;
using VRising.Models.Constants;
using VRising.Models.Data;
using VRising.Models.Enums;
using VRising.Models.Internal;
using VRising.Models.Localization;
using VRising.Models.RootModels;

namespace VRising.Models.Stations
{
    public class ResearchStationModel : ModelBase, IModel
    {
        public RisingEntity Entity { get; set; }


        public int ResearchStationId { get; set; }
        public string PrefabName { get; set; }


        [JsonIgnore]
        public BlueprintModel Blueprint => Database.Current.Blueprints.ContainsKey(ResearchStationId) ? Database.Current.Blueprints[ResearchStationId] : null;


        public string Icon { get; set; }

        [JsonIgnore] public List<TechUnlocks> TechUnlocks => new List<TechUnlocks>();

        public int Id => ResearchStationId;

        public int Rarity => 0;

        public string BasePath => BasePaths.ResearchStations;
        public ServantType StationServantTypes { get; set; }
        public CastleFloorTypes MatchingFloorType { get; set; }
        public ServantType BonusServantType { get; set; }
        public WorkstationLevel WorkstationLevel { get; set; }
        public HashSet<int> StationBonusIds { get; set; }
        public HashSet<int> ResearchIds { get; set; }

        [JsonIgnore]
        public List<UnlockSource> UnlockSources => Database.Current.UnlockSources.ContainsKey(ResearchStationId) ?
            Database.Current.UnlockSources[ResearchStationId] :
            null;

        public bool IsValid => true;

        public LocalizedResource LocalizedName { get; set; }
        public LocalizedResource LocalizedDescription { get; set; }
    }
}