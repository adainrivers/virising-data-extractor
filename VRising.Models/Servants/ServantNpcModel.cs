using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Localization;
using VRising.Models.BloodTypes;
using VRising.Models.Constants;
using VRising.Models.Internal;
using VRising.Models.Localization;
using VRising.Models.Npcs;
using VRising.Models.RootModels;

namespace VRising.Models.Servants
{
    public class ServantNpcModel : IModel
    {
        public int ServantNpcId { get; set; }
        public int Id => ServantNpcId;
        public int Rarity => 99;

        public string Icon { get; set; }
        public string PrefabName { get; set; }
        public string BasePath => $"{BasePaths.Servants}/npcs";
        public RisingEntity Entity { get; set; }
        public int FactionId => BaseNpc?.FactionId ?? 0;
        public int BloodTypeId => BaseNpc?.BloodTypeId ?? 0;


        public NpcModel BaseNpc
        {
            get
            {
                var baseNpcPrefabName = PrefabName.Replace("_Servant", string.Empty);
                if (Database.Current.Mappings.UnitPrefabNameEntityIdMap.TryGetValue(baseNpcPrefabName,
                        out var npcId))
                {
                    return Database.Current.Npcs[npcId];
                }
                return null;
            }
        }

        public BloodTypeModel BloodType => Database.Current.BloodTypes[BloodTypeId];
        public ServantFaction ServantFaction => ServantFactionMapper.Map(FactionId);

        public List<ServantPerkModel> ServantPerks
        {
            get
            {
                var bloodPerk = Database.Current.ServantPerks.Values.FirstOrDefault(p => p.BloodTypeId == BloodTypeId);
                var factionPerk =
                    Database.Current.ServantPerks.Values.FirstOrDefault(p => p.ServantFaction == ServantFaction);
                return new List<ServantPerkModel> { bloodPerk, factionPerk };
            }
        }

        public List<ServantMissionModel> MatchingMissions
        {
            get
            {
                return Database.Current.ServantMissions.Values
                    .Where(m => m.ServantPerks.All(sp => ServantPerks.Any(ssp => ssp == sp))).ToList();
            }
        }

        public LocalizedResource LocalizedName { get; set; }
        public LocalizedResource LocalizedDescription { get; set; }
    }


}