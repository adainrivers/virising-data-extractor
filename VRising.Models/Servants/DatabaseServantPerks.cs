namespace VRising.Models.Servants
{
    public class DatabaseServantPerks : DatabaseDictionary<ServantPerkModel>
    {
        private static DatabaseServantPerks _instance;
        public static DatabaseServantPerks Instance => _instance ??= new DatabaseServantPerks();

        private DatabaseServantPerks()
        {
            var builder = new ServantPerkModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["PerkData"];
            Populate(entityIds, builder.Build);
        }
    }
}