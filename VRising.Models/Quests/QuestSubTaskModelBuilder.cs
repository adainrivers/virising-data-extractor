using System;
using VRising.Models.Enums;
using VRising.Models.Internal;
using VRising.Models.Localization;

namespace VRising.Models.Quests
{
    internal class QuestSubTaskModelBuilder
    {
        public QuestSubTaskModel Build(RisingEntity entity)
        {
            var model = new QuestSubTaskModel
            {
                Entity = entity,
                QuestSubTaskId = entity.PrefabGuid,
                PrefabName = entity.PrefabName
            };

            if (entity.AchievementSubTaskData != null)
            {
                model.LocalizedTitle = new LocalizedResource(entity.AchievementSubTaskData.TaskTitle.Key,
                    entity.AchievementSubTaskData.TaskTitle.Text);
                model.ProgressType = Enum.Parse<AchievementProgressType>(entity.AchievementSubTaskData.ProgressType);
                model.ProgressLinkType = Enum.Parse<AchievementProgressLinkType>(entity.AchievementSubTaskData.ProgressLinkType);
                model.PrefabReference = entity.AchievementSubTaskData.PrefabReference;
                model.TechReference = entity.AchievementSubTaskData.TechReference;
                model.RequiredCompletedCount = entity.AchievementSubTaskData.RequiredCompletedCount;
                model.ConditionId = entity.AchievementSubTaskData.ConditionId;
            }

            return model;
        }
    }
}