using System.Collections.Generic;
using VRising.Models.Data;
using VRising.Models.Internal;
using VRising.Models.RootModels;

namespace VRising.Models.Drops
{
    public class DropTableModel : ModelBase
    {
        public RisingEntity Entity { get; set; }

        public int DropTableId { get; set; }

        public List<DropTableEntry> Entries { get; set; }

        public List<ItemDropChance> DropChances { get; set; }
        public string PrefabName { get; set; }
        public string Name { get; set; }

        public static DropTableModel FromEntity(RisingEntity entity)
        {
            return new DropTableModelBuilder().Build(entity);
        }
    }
}