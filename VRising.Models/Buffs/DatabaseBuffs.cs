namespace VRising.Models.Buffs
{
    public class DatabaseBuffs : DatabaseDictionary<BuffModel>
    {
        private static DatabaseBuffs _instance;
        public static DatabaseBuffs Instance => _instance ??= new DatabaseBuffs();

        private DatabaseBuffs()
        {
            var builder = new BuffModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["Buff"];
            Populate(entityIds, builder.Build);
        }
    }
}