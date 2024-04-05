using System;
using VRising.Models.Internal;
using VRising.Models.Servants;

namespace VRising.Models.Constants
{
    public static class ServantFactionMapper
    {
        public static ServantFaction Map(int factionId)
        {
            if (!Database.Current.Entities.TryGetValue(factionId, out var factionEntity))
            {
                return ServantFaction.Unknown;
            }

            switch (factionEntity.PrefabName)
            {
                case "Faction_ChurchOfLum_SpotShapeshiftVampire":
                case "Faction_ChurchOfLum":
                    return ServantFaction.Silver;
                case "Faction_Bandits":
                    return ServantFaction.Farbane;
                case "Faction_Militia":
                    return ServantFaction.Dunley;
                default:
                    return ServantFaction.Unknown;
            }
        }

        public static string GetName(this ServantFaction servantFaction)
        {
            switch (servantFaction)
            {
                case ServantFaction.Unknown:
                    return "Unknown";
                case ServantFaction.Cursed:
                    return "Cursed Forest";
                case ServantFaction.Dunley:
                    return "Militia";
                case ServantFaction.Farbane:
                    return "Bandits";
                case ServantFaction.Silver:
                    return "Church of Luminance";
                default:
                    throw new ArgumentOutOfRangeException(nameof(servantFaction), servantFaction, null);
            }
        }
    }
}
