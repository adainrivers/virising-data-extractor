namespace VRising.Models.Servants
{
    public class DatabaseServantNpcs : DatabaseDictionary<ServantNpcModel>
    {
        private static DatabaseServantNpcs _instance;
        public static DatabaseServantNpcs Instance => _instance ??= new DatabaseServantNpcs();

        private DatabaseServantNpcs()
        {
            var builder = new ServantNpcModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["ServantData"];
            Populate(entityIds, builder.Build);
        }
    }
}