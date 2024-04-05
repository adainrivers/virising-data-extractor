using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Localization;
using VRising.Models.BloodTypes;
using VRising.Models.Constants;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;
using VRising.Models.RootModels;

namespace VRising.Models.Servants
{
    public class ServantPerkModel : IModel
    {
        public int ServantPerkId { get; set; }
        public int Id => ServantPerkId;
        public int Rarity => 0;
        public string Icon { get; set; }
        public string PrefabName { get; set; }
        public string BasePath => $"{BasePaths.Servants}/perks";
        public RisingEntity Entity { get; set; }


        public int BloodTypeId { get; set; }
        public ServantFaction ServantFaction { get; set; }
        public BloodTypeModel BloodType => Database.Current.BloodTypes.GetOrNull(BloodTypeId);

        public List<ServantNpcModel> ServantNpcs
        {
            get
            {
                return Database.Current.ServantNpcs.Values
                    .Where(n => n.ServantPerks.Any(p => p.ServantPerkId == ServantPerkId)).ToList();
            }
        }
        public List<ServantMissionModel> MissionsWithPerk
        {
            get
            {
                return Database.Current.ServantMissions.Values
                    .Where(m => m.ServantPerks.Any(p => p.ServantPerkId == ServantPerkId)).ToList();
            }
        }
        public LocalizedResource LocalizedName { get; set; }
        public LocalizedResource LocalizedDescription { get; set; }
    }
}
