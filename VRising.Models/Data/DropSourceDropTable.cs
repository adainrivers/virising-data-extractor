using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using VRising.Models.Drops;
using VRising.Models.Enums;

namespace VRising.Models.Data
{
    public class DropSourceDropTable
    {
        public int DropTableId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public RelicType RelicType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public DropTriggerType DropTrigger { get; set; }

        [JsonIgnore]
        public DropTableModel DropTable => Database.Current.DropTables[DropTableId];
    }
}