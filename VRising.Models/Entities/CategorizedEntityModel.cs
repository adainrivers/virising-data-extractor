using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using VRising.Models.Enums;
using VRising.Models.Internal;

namespace VRising.Models.Entities
{
    public class CategorizedEntityModel
    {
        public RisingEntity Entity { get; set; }

        public int CategorizedEntityId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public MainEntityCategory MainCategory { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public UnitCategory UnitCategory { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public StructureCategory StructureCategory { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public MaterialCategory MaterialCategory { get; set; }

        public string PrefabName { get; set; }

        public static CategorizedEntityModel FromEntity(RisingEntity entity)
        {
            return new CategorizedEntityModelBuilder().Build(entity);
        }
    }
}