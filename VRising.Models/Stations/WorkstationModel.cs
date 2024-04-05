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
using VRising.Models.Npcs;
using VRising.Models.Recipes;
using VRising.Models.RootModels;

namespace VRising.Models.Stations
{
    public class WorkstationModel : ModelBase, IModel
    {
        public RisingEntity Entity { get; set; }


        public int WorkstationId { get; set; }
        public string PrefabName { get; set; }

        public WorkstationType WorkstationType { get; set; }

        [JsonIgnore]
        public BlueprintModel Blueprint => Database.Current.Blueprints.ContainsKey(WorkstationId) ? Database.Current.Blueprints[WorkstationId] : null;

        [JsonIgnore]
        public NpcModel Trader
        {
            get
            {
                if (WorkstationType == WorkstationType.Trader)
                {
                    return Database.Current.Npcs[WorkstationId];
                }

                return null;
            }
        }

        public string Icon { get; set; }

        [JsonIgnore]
        public List<RecipeModel> WorkstationRecipes => WorkstationRecipeIds.Select(id => Database.Current.Recipes[id]).ToList();
        [JsonIgnore]
        public List<RecipeModel> RefinementRecipes => RefinementRecipeIds.Select(id => Database.Current.Recipes[id]).ToList();

        public int Id => WorkstationId;

        public int Rarity => 0;

        public string BasePath => BasePaths.Workstations;
        public ServantType StationServantTypes { get; set; }
        public CastleFloorTypes MatchingFloorType { get; set; }
        public ServantType BonusServantType { get; set; }
        public WorkstationLevel WorkstationLevel { get; set; }
        public HashSet<int> StationBonusIds { get; set; }
        public HashSet<int> WorkstationRecipeIds { get; set; }
        public HashSet<int> RefinementRecipeIds { get; set; }

        [JsonIgnore]
        public List<UnlockSource> UnlockSources => Database.Current.UnlockSources.ContainsKey(WorkstationId) ?
            Database.Current.UnlockSources[WorkstationId] :
            null;

        private static readonly HashSet<int> InvalidWorkstations = new HashSet<int> { -465055967, 2028604015, -1145844738 };

        public bool IsValid => !InvalidWorkstations.Contains(WorkstationId);

        public LocalizedResource LocalizedName { get; set; }
        public LocalizedResource LocalizedDescription { get; set; }
    }
}