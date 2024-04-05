namespace VRising.Models.Drops
{
    public class DatabaseDropTables : DatabaseDictionary<DropTableModel>
    {
        private static DatabaseDropTables _instance;
        public static DatabaseDropTables Instance => _instance ??= new DatabaseDropTables();

        private DatabaseDropTables()
        {
            var builder = new DropTableModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["DropTableDataBuffer"];
            Populate(entityIds, builder.Build);
        }
    }
}