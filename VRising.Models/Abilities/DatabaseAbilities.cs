using System.Linq;

namespace VRising.Models.Abilities
{
    public class DatabaseAbilities : DatabaseDictionary<AbilityGroupModel>
    {
        private static DatabaseAbilities _instance;
        public static DatabaseAbilities Instance => _instance ??= new DatabaseAbilities();

        private DatabaseAbilities()
        {
            var builder = new AbilityGroupModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["AbilityGroupState"]
                .Union(Database.Current.ComponentTypeToEntitiesMap["AbilityState"]);
            Populate(entityIds, builder.Build, a => a.LocalizedName != null && a.LocalizedName.Text != null);
        }
    }
}
