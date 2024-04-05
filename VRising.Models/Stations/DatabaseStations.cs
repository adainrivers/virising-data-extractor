using System.Linq;

namespace VRising.Models.Stations
{
    public class DatabaseStations : DatabaseDictionary<WorkstationModel>
    {
        private static DatabaseStations _instance;
        public static DatabaseStations Instance => _instance ??= new DatabaseStations();

        private DatabaseStations()
        {
            var builder = new WorkstationModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["Workstation"]
                .Union(Database.Current.ComponentTypeToEntitiesMap["Refinementstation"])
                .Union(Database.Current.ComponentTypeToEntitiesMap["UnitSpawnerstation"]);
            Populate(entityIds, builder.Build, model => model.IsValid);
        }
    }
}