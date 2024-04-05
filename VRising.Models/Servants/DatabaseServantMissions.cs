namespace VRising.Models.Servants
{
    public class DatabaseServantMissions : DatabaseDictionary<ServantMissionModel>
    {
        private static DatabaseServantMissions _instance;
        public static DatabaseServantMissions Instance => _instance ??= new DatabaseServantMissions();

        private DatabaseServantMissions()
        {
            var builder = new ServantMissionModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["MissionData"];
            Populate(entityIds, builder.Build, m=> !m.PrefabName.EndsWith("TEST"));
        }
    }
}