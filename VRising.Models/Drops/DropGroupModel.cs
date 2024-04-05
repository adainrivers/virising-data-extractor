using System.Collections.Generic;
using VRising.Models.Data;
using VRising.Models.Internal;
using VRising.Models.RootModels;

namespace VRising.Models.Drops
{
    public class DropGroupModel : ModelBase
    {
        public RisingEntity Entity { get; set; }

        public int DropGroupId { get; set; }

        public List<DropGroupEntry> Entries { get; set; }
        public string PrefabName { get; set; }
        public string Name { get; set; }

        public static DropGroupModel FromEntity(RisingEntity entity)
        {
            return new DropGroupModelBuilder().Build(entity);
        }
    }
}