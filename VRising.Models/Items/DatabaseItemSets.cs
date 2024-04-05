namespace VRising.Models.Items
{
    public class DatabaseItemSets : DatabaseDictionary<ItemSetModel>
    {
        private static DatabaseItemSets _instance;
        public static DatabaseItemSets Instance => _instance ??= new DatabaseItemSets();

        private DatabaseItemSets()
        {
            var builder = new ItemSetModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["EquipmentSet"];
            Populate(entityIds, builder.Build);
        }
    }
}