using System.Collections.Generic;
using Newtonsoft.Json;
using VRising.Models.Data;
using VRising.Models.Internal;
using VRising.Models.Npcs;
using VRising.Models.RootModels;

namespace VRising.Models.Drops
{
    public class DropSourceModel : ModelBase
    {
        public RisingEntity Entity { get; set; }

        public int SourceId { get; set; }
        public List<DropSourceDropTable> DropTables { get; set; }

        [JsonIgnore]
        public NpcModel Npc => Database.Current.Npcs.ContainsKey(SourceId)
            ? Database.Current.Npcs[SourceId]
            : null;

        public static DropSourceModel FromEntity(RisingEntity entity)
        {
            return new DropSourceModelBuilder().Build(entity);
        }
    }
}