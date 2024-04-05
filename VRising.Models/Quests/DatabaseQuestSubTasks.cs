namespace VRising.Models.Quests
{
    public class DatabaseQuestSubTasks : DatabaseDictionary<QuestSubTaskModel>
    {
        private static DatabaseQuestSubTasks _instance;
        public static DatabaseQuestSubTasks Instance => _instance ??= new DatabaseQuestSubTasks();

        private DatabaseQuestSubTasks()
        {
            var builder = new QuestSubTaskModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["AchievementSubTaskData"];
            Populate(entityIds, builder.Build);
        }
    }
}