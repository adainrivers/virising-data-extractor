namespace VRising.Models.Stations
{
    public class DatabaseResearchStations : DatabaseDictionary<ResearchStationModel>
    {
        private static DatabaseResearchStations _instance;
        public static DatabaseResearchStations Instance => _instance ??= new DatabaseResearchStations();

        private DatabaseResearchStations()
        {
            var builder = new ResearchStationModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["ResearchStation"];
            Populate(entityIds, builder.Build);
        }
    }
}