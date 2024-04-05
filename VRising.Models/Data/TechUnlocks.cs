using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Abilities;
using VRising.Models.Blueprints;
using VRising.Models.Buffs;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Items;
using VRising.Models.Npcs;
using VRising.Models.Quests;
using VRising.Models.Recipes;

namespace VRising.Models.Data
{

    public class TechUnlocks
    {
        public TechUnlocks() { }

        public static TechUnlocks FromTechEntities(IEnumerable<RisingEntity> techEntities)
        {
            var result = new TechUnlocks();
            foreach (var techEntity in techEntities)
            {
                if (techEntity.ProgressionBookShapeshiftElement != null)
                {
                    foreach (var buffer in techEntity.ProgressionBookShapeshiftElement)
                    {
                        result.UnlockAbilityIds.Add(buffer.Shapeshift);
                    }
                }

                if (techEntity.TechUnlockAbilityBuffer != null)
                {
                    foreach (var buffer in techEntity.TechUnlockAbilityBuffer)
                    {
                        result.UnlockAbilityIds.Add(buffer.Guid);
                    }
                }

                if (techEntity.TechUnlockBlueprintBuffer != null)
                {
                    foreach (var buffer in techEntity.TechUnlockBlueprintBuffer)
                    {
                        result.UnlockBlueprintIds.Add(buffer.Guid);
                    }
                }

                if (techEntity.TechUnlockPassiveBuffer != null)
                {
                    foreach (var buffer in techEntity.TechUnlockPassiveBuffer)
                    {
                        result.UnlockPassiveIds.Add(buffer.Guid);
                    }
                }

                if (techEntity.TechUnlockRecipeBuffer != null)
                {
                    foreach (var buffer in techEntity.TechUnlockRecipeBuffer)
                    {
                        result.UnlockRecipeIds.Add(buffer.Guid);
                    }
                }
            }

            return result;
        }

        public static TechUnlocks FromJournalEntity(RisingEntity journalEntity)
        {
            var result = new TechUnlocks();

            if (journalEntity.ProgressionBookRecipeElement != null)
            {
                foreach (var buffer in journalEntity.ProgressionBookRecipeElement)
                {
                    result.UnlockRecipeIds.Add(buffer.Recipe);
                }
            }

            if (journalEntity.ProgressionBookBlueprintElement != null)
            {
                foreach (var buffer in journalEntity.ProgressionBookBlueprintElement)
                {
                    result.UnlockBlueprintIds.Add(buffer.Blueprint);
                }
            }

            if (journalEntity.ProgressionBookTechElement != null)
            {
                var techEntities =
                    journalEntity.ProgressionBookTechElement.Select(b => Database.Current.Entities[b.Tech]);
                var techUnlocks = TechUnlocks.FromTechEntities(techEntities);
                result.UnlockAbilityIds.AddRange(techUnlocks.UnlockAbilityIds);
                result.UnlockBlueprintIds.AddRange(techUnlocks.UnlockBlueprintIds);
                result.UnlockPassiveIds.AddRange(techUnlocks.UnlockPassiveIds);
                result.UnlockRecipeIds.AddRange(techUnlocks.UnlockRecipeIds);
            }

            return result;
        }

        public HashSet<int> UnlockAbilityIds { get; set; } = new HashSet<int>();
        public HashSet<int> UnlockBlueprintIds { get; set; } = new HashSet<int>();
        public HashSet<int> UnlockPassiveIds { get; set; } = new HashSet<int>();
        public HashSet<int> UnlockRecipeIds { get; set; } = new HashSet<int>();

        public bool UnlocksTech =>
            UnlocksAbilities.Any() ||
            UnlocksBlueprints.Any() ||
            UnlocksPassives.Any() ||
            UnlocksRecipes.Any();

        public List<AbilityGroupModel> UnlocksAbilities =>
            UnlockAbilityIds?.Select(aid => Database.Current.AbilityGroups.GetOrNull(aid)).ToNonNullList();

        public List<BlueprintModel> UnlocksBlueprints =>
            UnlockBlueprintIds?.Select(aid => Database.Current.Blueprints.GetOrNull(aid)).ToNonNullList();

        public List<BuffModel> UnlocksPassives =>
            UnlockPassiveIds?.Select(aid => Database.Current.Buffs.GetOrNull(aid)).ToNonNullList();

        public List<RecipeModel> UnlocksRecipes =>
            UnlockRecipeIds?.Select(aid => Database.Current.Recipes.GetOrNull(aid)).ToNonNullList();

        public void Register(ItemModel source)
        {
            foreach (var prefabGuid in UnlockAbilityIds.Union(UnlockRecipeIds.Union(UnlockBlueprintIds).Union(UnlockPassiveIds)))
            {
                if (!Database.Current.UnlockSources.ContainsKey(prefabGuid))
                {
                    Database.Current.UnlockSources[prefabGuid] = new List<UnlockSource>();
                }
                Database.Current.UnlockSources[prefabGuid].Add(new UnlockSource { ItemId = source.ItemId });
            }
        }

        public void Register(NpcModel source)
        {
            foreach (var prefabGuid in UnlockAbilityIds.Union(UnlockRecipeIds.Union(UnlockBlueprintIds).Union(UnlockPassiveIds)))
            {
                if (!Database.Current.UnlockSources.ContainsKey(prefabGuid))
                {
                    Database.Current.UnlockSources[prefabGuid] = new List<UnlockSource>();
                }
                Database.Current.UnlockSources[prefabGuid].Add(new UnlockSource { UnitId = source.NpcId });
            }
        }

        public void Register(QuestModel source)
        {
            foreach (var prefabGuid in UnlockAbilityIds.Union(UnlockRecipeIds.Union(UnlockBlueprintIds).Union(UnlockPassiveIds)))
            {
                if (!Database.Current.UnlockSources.ContainsKey(prefabGuid))
                {
                    Database.Current.UnlockSources[prefabGuid] = new List<UnlockSource>();
                }
                Database.Current.UnlockSources[prefabGuid].Add(new UnlockSource { QuestId = source.QuestId });
            }
        }
    }
}
