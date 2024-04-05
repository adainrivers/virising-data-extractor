namespace VRising.Models.BloodTypes
{
    public class DatabaseBloodTypes : DatabaseDictionary<BloodTypeModel>
    {
        private static DatabaseBloodTypes _instance;
        public static DatabaseBloodTypes Instance => _instance ??= new DatabaseBloodTypes();

        private DatabaseBloodTypes()
        {
            var builder = new BloodTypeModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["ManagedUnitBloodTypeData"];
            Populate(entityIds, builder.Build);
        }
    }
}