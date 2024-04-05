namespace VRising.Models.Blueprints
{
    public class DatabaseBlueprints : DatabaseDictionary<BlueprintModel>
    {
        private static DatabaseBlueprints _instance;
        public static DatabaseBlueprints Instance => _instance ??= new DatabaseBlueprints();

        private DatabaseBlueprints()
        {
            var builder = new BlueprintModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["BlueprintData"];
            Populate(entityIds, builder.Build, b => b.LocalizedName != null && b.LocalizedName.Text != null);
        }
    }
}