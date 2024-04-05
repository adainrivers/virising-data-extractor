using System.Collections.Generic;
using System.Linq;

namespace VRising.Models.Containers
{
    public class DatabaseContainers : DatabaseDictionary<ContainerModel>
    {
        private static DatabaseContainers _instance;
        public static DatabaseContainers Instance => _instance ??= new DatabaseContainers();

        private DatabaseContainers()
        {
            var entities = Database.Current.ComponentTypeToEntitiesMap["DropTableBuffer"].Select(id => Database.Current.Entities[id]);
            var containers = entities.Where(e => e.DropTableBuffer != null && e.DropTableBuffer.Any(d => d.DropTrigger == "OnSpawnDropInInventory"))
                .Select(e => e.PrefabGuid);

            var builder = new ContainerModelBuilder();
            Populate(containers, builder.Build);
        }
    }
}