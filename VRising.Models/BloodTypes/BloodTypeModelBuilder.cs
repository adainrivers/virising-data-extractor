using System.Collections.Generic;
using System.Linq;
using VRising.Models.Data;
using VRising.Models.Internal;
using VRising.Models.Localization;

namespace VRising.Models.BloodTypes
{
    internal class BloodTypeModelBuilder
    {
        public BloodTypeModel Build(RisingEntity entity)
        {
            var model = new BloodTypeModel
            {
                Entity = entity,
                BloodTypeId = entity.PrefabGuid,
                PrefabName = entity.PrefabName
            };

            model.TypeName = model.PrefabName.Replace("(UnitBloodType) BloodType_", string.Empty);

            model.BloodTypeBuffs = entity.UnitBloodTypeBuffs?.Select(b => new UnitBloodTypeBuff
            {
                MinQuality = b.MinQuality,
                BuffId = b.BuffType
            }).ToList() ?? new List<UnitBloodTypeBuff>();

            if (entity.ManagedUnitBloodTypeData != null)
            {
                model.LocalizedName = new LocalizedResource(entity.ManagedUnitBloodTypeData.Name.Key,
                    entity.ManagedUnitBloodTypeData.Name.Text);
                model.Icon = entity.ManagedUnitBloodTypeData.Icon;
                model.Icon2 = entity.ManagedUnitBloodTypeData.Icon2;
            }

            return model;
        }
    }
}