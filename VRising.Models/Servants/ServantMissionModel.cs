using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Localization;
using VRising.Models.Constants;
using VRising.Models.Data;
using VRising.Models.Drops;
using VRising.Models.Internal;
using VRising.Models.Localization;
using VRising.Models.RootModels;

namespace VRising.Models.Servants
{
    public class ServantMissionModel : IModel
    {
        private readonly ServantMissionProperties _properties;

        public ServantMissionModel()
        {
            _properties = new ServantMissionProperties(this);
        }

        public int ServantMissionId { get; set; }
        public int Id => ServantMissionId;
        public int Rarity => 99;
        public string Icon { get; set; }
        public string PrefabName { get; set; }
        public string BasePath => $"{BasePaths.Servants}/missions";
        public RisingEntity Entity { get; set; }

        public HashSet<int> ServantPerkIds { get; set; }
        public string Location { get; set; }

        public List<DropTableModel> DropTables => _properties.DropTables.Value;
        public List<ItemDropChance> DropChances => _properties.DropChances.Value;

        public List<ServantPerkModel> ServantPerks =>
            ServantPerkIds.Select(id => Database.Current.ServantPerks[id]).ToList();

        public List<ServantNpcModel> MatchingServants
        {
            get
            {
                return Database.Current.ServantNpcs.Values
                    .Where(n => n.ServantPerks.All(sp => ServantPerks.Any(ssp => sp == ssp))).ToList();
            }
        }

        public int ServantSlots { get; set; }
        public int Difficulty { get; set; }
        public LocalizedResource LocalizedName { get; set; }
        public LocalizedResource LocalizedDescription { get; set; }
    }
}