using System.Linq;

namespace VRising.Models.Fishing
{
    public class DatabaseFishingSpots : DatabaseDictionary<FishingSpotModel>
    {
        private static DatabaseFishingSpots _instance;
        public static DatabaseFishingSpots Instance => _instance ??= new DatabaseFishingSpots();

        private DatabaseFishingSpots()
        {
            var entities = Database.Current.ComponentTypeToEntitiesMap["DropTableBuffer"].Select(id => Database.Current.Entities[id]);
            var FishingSpots = entities.Where(e => e.DropTableBuffer != null && e.DropTableBuffer.Any(d => d.DropTrigger == "OnSalvageDestroy"))
                .Select(e => e.PrefabGuid).Distinct();

            var builder = new FishingSpotModelBuilder();
            Populate(FishingSpots, builder.Build);
        }
    }
}