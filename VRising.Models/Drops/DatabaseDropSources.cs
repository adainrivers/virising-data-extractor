namespace VRising.Models.Drops
{
    public class DatabaseDropSources : DatabaseDictionary<DropSourceModel>
    {
        private static DatabaseDropSources _instance;
        public static DatabaseDropSources Instance => _instance ??= new DatabaseDropSources();

        private DatabaseDropSources()
        {
            var builder = new DropSourceModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["DropTableBuffer"];
            Populate(entityIds, builder.Build);
        }
    }
}