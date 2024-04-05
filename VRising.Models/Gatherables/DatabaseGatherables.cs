using System.Linq;

namespace VRising.Models.Gatherables
{
    public class DatabaseGatherables : DatabaseDictionary<GatherableModel>
    {
        private static DatabaseGatherables _instance;
        public static DatabaseGatherables Instance => _instance ??= new DatabaseGatherables();

        private DatabaseGatherables()
        {
            var entities = Database.Current.ComponentTypeToEntitiesMap["DropTableBuffer"].Select(id => Database.Current.Entities[id]);
            var gatherables = entities.Where(e => e.DropTableBuffer != null && e.DropTableBuffer.Any(d => d.DropTrigger == "YieldResourceOnDamageTaken"))
                .Select(e => e.PrefabGuid).Distinct();

            var builder = new GatherableModelBuilder();
            Populate(gatherables, builder.Build);
        }
    }
}