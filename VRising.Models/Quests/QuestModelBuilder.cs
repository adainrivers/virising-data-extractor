using System.Collections.Generic;
using System.Linq;
using VRising.Models.Data;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;

namespace VRising.Models.Quests
{
    internal class QuestModelBuilder
    {
        public QuestModel Build(RisingEntity entity)
        {
            var model = new QuestModel
            {
                Entity = entity,
                QuestId = entity.PrefabGuid,
                PrefabName = entity.PrefabName
            };

            if (entity.ManagedAchievementData != null)
            {
                model.LocalizedName = new LocalizedResource(
                    entity.ManagedAchievementData.Quest.Key,
                    entity.ManagedAchievementData.Quest.Text);

                model.LocalizedFlavor = new LocalizedResource(
                    entity.ManagedAchievementData.Flavor.Key,
                    entity.ManagedAchievementData.Flavor.Text);
            }

            if (entity.AchievementData != null)
            {
                model.RewardId = entity.AchievementData.Reward;
                if (Database.Current.Entities.TryGetValue(model.RewardId, out var rewardEntity))
                {
                    model.TechUnlocks = TechUnlocks.FromJournalEntity(rewardEntity);
                    model.TechUnlocks.Register(model);
                }

                model.DependencyId = entity.AchievementData.Dependency;
            }

            model.QuestSubTaskEntryIds = entity.AchievementSubTaskEntry?.Select(a => a.PrefabGuid).ToHashSet() ??
                                               new HashSet<int>();

            return model;
        }
    }
}