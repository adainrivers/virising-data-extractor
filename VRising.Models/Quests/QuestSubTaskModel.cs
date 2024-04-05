using Newtonsoft.Json;
using VRising.Models.Abilities;
using VRising.Models.Blueprints;
using VRising.Models.Buffs;
using VRising.Models.Enums;
using VRising.Models.Internal;
using VRising.Models.Items;
using VRising.Models.Localization;
using VRising.Models.Npcs;
using VRising.Models.Recipes;
using VRising.Models.RootModels;
using VRising.Models.Stations;

namespace VRising.Models.Quests
{
    public class QuestSubTaskModel : ModelBase
    {
        public RisingEntity Entity { get; set; }

        public int QuestSubTaskId { get; set; }
        public string PrefabName { get; set; }
        public AchievementProgressType ProgressType { get; set; }
        public AchievementProgressLinkType ProgressLinkType { get; set; }
        public int PrefabReference { get; set; }
        public int TechReference { get; set; }
        public int RequiredCompletedCount { get; set; }
        public int ConditionId { get; set; }

        [JsonIgnore]
        public RecipeModel Recipe
        {
            get
            {
                if (PrefabReference == 0)
                {
                    return null;
                }

                if (!Database.Current.Items.TryGetValue(PrefabReference, out var itemModel))
                {
                    return null;
                }

                if (!itemModel.CanBeCrafted)
                {
                    return null;
                }

                return itemModel.CraftingRecipes[0];
            }
        }

        [JsonIgnore]
        public NpcModel Npc
        {
            get
            {
                if (PrefabReference == 0)
                {
                    return null;
                }

                return !Database.Current.Npcs.TryGetValue(PrefabReference, out var model) ? null : model;
            }
        }

        [JsonIgnore]
        public BlueprintModel Blueprint
        {
            get
            {
                if (PrefabReference == 0)
                {
                    return null;
                }

                return !Database.Current.Blueprints.TryGetValue(PrefabReference, out var model) ? null : model;
            }
        }

        [JsonIgnore]
        public WorkstationModel Workstation
        {
            get
            {
                if (PrefabReference == 0)
                {
                    return null;
                }

                return !Database.Current.Workstations.TryGetValue(PrefabReference, out var model) ? null : model;
            }
        }

        [JsonIgnore]
        public ItemModel Item
        {
            get
            {
                if (PrefabReference == 0)
                {
                    return null;
                }

                return !Database.Current.Items.TryGetValue(PrefabReference, out var model) ? null : model;
            }
        }
        [JsonIgnore]
        public AbilityGroupModel AbilityGroup
        {
            get
            {
                if (PrefabReference == 0)
                {
                    return null;
                }

                return !Database.Current.AbilityGroups.TryGetValue(PrefabReference, out var model) ? null : model;
            }
        }

        [JsonIgnore]
        public BuffModel Buff
        {
            get
            {
                if (PrefabReference == 0)
                {
                    return null;
                }

                return !Database.Current.Buffs.TryGetValue(PrefabReference, out var model) ? null : model;
            }
        }

        public LocalizedResource LocalizedTitle { get; set; }

    }
}