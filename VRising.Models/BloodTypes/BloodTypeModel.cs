using System.Collections.Generic;
using VRising.Localization;
using VRising.Models.Constants;
using VRising.Models.Data;
using VRising.Models.Internal;
using VRising.Models.Localization;
using VRising.Models.RootModels;

namespace VRising.Models.BloodTypes
{
    public class BloodTypeModel : ModelBase, IModel
    {
        public RisingEntity Entity { get; set; }

        public int BloodTypeId { get; set; }
        public int Id => BloodTypeId;
        public int Rarity => 0;
        public string Icon { get; set; }
        public string Icon2 { get; set; }

        public string PrefabName { get; set; }
        public string BasePath => BasePaths.BloodTypes;
        public LocalizedResource LocalizedName { get; set; }

        public string TypeName { get; set; }
        public List<UnitBloodTypeBuff> BloodTypeBuffs { get; set; }
    }
}