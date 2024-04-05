using System.Linq;
using VRising.Models.Constants;

namespace VRising.Models.Quests
{
    public class DatabaseQuests : DatabaseDictionary<QuestModel>
    {
        private static DatabaseQuests _instance;
        public static DatabaseQuests Instance => _instance ??= new DatabaseQuests();

        private DatabaseQuests()
        {
            var builder = new QuestModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["ManagedAchievementData"].Where(id => KnownEntities.ValidQuests.Contains(id));
            Populate(entityIds, builder.Build, model => model.SubTasks != null && model.SubTasks.Count > 0);
        }
    }
}