using System;
using System.Linq;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;

namespace VRising.Models.Servants
{
    internal class ServantPerkModelBuilder
    {
        public ServantPerkModel Build(RisingEntity entity)
        {
            var model = new ServantPerkModel
            {
                Entity = entity,
                ServantPerkId = entity.PrefabGuid,
                PrefabName = entity.PrefabName
            };
            if (entity.ManagedPerkData != null)
            {
                model.LocalizedName = new LocalizedResource(entity.ManagedPerkData.Name.Key,
                    entity.ManagedPerkData.Name.Text);

                model.LocalizedDescription = new LocalizedResource(
                    entity.ManagedPerkData.Description.Key.Key,
                    entity.ManagedPerkData.Description.Key.Text,
                    entity.LocalizedStringBuilderParameter?.ToDictionary(l => l.Key, l => l.Value));

                model.Icon = entity.ManagedPerkData.Icon;
            }

            if (model.PrefabName.Contains("BloodType"))
            {
                var bloodTypeName = model.PrefabName.Replace("ServantPerk_BloodType_", string.Empty);
                var bloodType = Database.Current.BloodTypes.Values.FirstOrDefault(b => b.TypeName == bloodTypeName);
                if (bloodType != null)
                {
                    model.BloodTypeId = bloodType.Id;
                }
            }

            if (model.PrefabName.Contains("Faction"))
            {
                var factionName = model.PrefabName.Replace("ServantPerk_Faction_", string.Empty).Replace("Expert", string.Empty);
                if (Enum.TryParse<ServantFaction>(factionName, out var faction))
                {
                    model.ServantFaction = faction;
                }
            }

            return model;
        }
    }
}