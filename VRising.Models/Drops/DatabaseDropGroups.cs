namespace VRising.Models.Drops
{
    public class DatabaseDropGroups : DatabaseDictionary<DropGroupModel>
    {
        private static DatabaseDropGroups _instance;
        public static DatabaseDropGroups Instance => _instance ??= new DatabaseDropGroups();

        private DatabaseDropGroups()
        {
            var builder = new DropGroupModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["ItemDataDropGroupBuffer"];
            Populate(entityIds, builder.Build);
        }
    }
}