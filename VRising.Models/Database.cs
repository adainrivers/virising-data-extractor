using System.Collections.Generic;
using VRising.Models.Abilities;
using VRising.Models.BloodTypes;
using VRising.Models.Blueprints;
using VRising.Models.Buffs;
using VRising.Models.Containers;
using VRising.Models.Data;
using VRising.Models.Drops;
using VRising.Models.Entities;
using VRising.Models.Enums;
using VRising.Models.Fishing;
using VRising.Models.Gatherables;
using VRising.Models.Internal;
using VRising.Models.Internal.BuildMenu;
using VRising.Models.Items;
using VRising.Models.Npcs;
using VRising.Models.Quests;
using VRising.Models.Recipes;
using VRising.Models.Servants;
using VRising.Models.Stations;
using VRising.Models.UnitLocations.Models;

namespace VRising.Models
{
    public class Database
    {
        public RisingBuildMenu BuildMenu;
        public Dictionary<string, HashSet<int>> ComponentTypeToEntitiesMap;
        public Dictionary<int, RisingEntity> Entities;
        public Dictionary<ItemCategory, LocalizedString> ItemCategoryNames;
        public Dictionary<int, List<UnlockSource>> UnlockSources = new Dictionary<int, List<UnlockSource>>();

        public Database()
        {
            Mappings = new DatabaseMappings(this);
        }

        public static Database Current { get; set; }

        public DatabaseMappings Mappings { get; }

        public DatabaseItems Items => DatabaseItems.Instance;
        public DatabaseRecipes Recipes => DatabaseRecipes.Instance;
        public DatabaseAbilities AbilityGroups => DatabaseAbilities.Instance;
        public DatabaseBloodTypes BloodTypes => DatabaseBloodTypes.Instance;
        public DatabaseBuffs Buffs => DatabaseBuffs.Instance;
        public DatabaseBlueprints Blueprints => DatabaseBlueprints.Instance;
        public DatabaseStations Workstations => DatabaseStations.Instance;
        public DatabaseQuests Quests => DatabaseQuests.Instance;
        public DatabaseQuestSubTasks QuestSubTasks => DatabaseQuestSubTasks.Instance;
        public DatabaseDropGroups DropGroups => DatabaseDropGroups.Instance;
        public DatabaseDropSources DropSources => DatabaseDropSources.Instance;
        public DatabaseDropTables DropTables => DatabaseDropTables.Instance;
        public DatabaseItemSets ItemSets => DatabaseItemSets.Instance;
        public DatabaseResearchStations ResearchStations => DatabaseResearchStations.Instance;
        public DatabaseNpcs Npcs => DatabaseNpcs.Instance;
        public DatabaseCategorizedEntities CategorizedEntities => DatabaseCategorizedEntities.Instance;
        public DatabaseServantNpcs ServantNpcs => DatabaseServantNpcs.Instance;
        public DatabaseServantPerks ServantPerks => DatabaseServantPerks.Instance;
        public DatabaseServantMissions ServantMissions => DatabaseServantMissions.Instance;
        public DatabaseUnitLocations UnitLocations => DatabaseUnitLocations.Instance;
        public DatabaseContainers Containers => DatabaseContainers.Instance;
        public DatabaseGatherables Gatherables => DatabaseGatherables.Instance;
        public DatabaseFishingSpots FishingSpots => DatabaseFishingSpots.Instance;

        public void Initialize()
        {
            _ = UnitLocations;
            _ = Items;
            _ = Recipes;
            _ = AbilityGroups;
            _ = BloodTypes;
            _ = Buffs;
            _ = Blueprints;
            _ = Workstations;
            _ = Quests;
            _ = QuestSubTasks;
            _ = DropGroups;
            _ = DropSources;
            _ = DropTables;
            _ = ItemSets;
            _ = ResearchStations;
            _ = Npcs;
            _ = CategorizedEntities;
            _ = ServantNpcs;
            _ = ServantPerks;
            _ = ServantMissions;
            _ = Containers;
            _ = Gatherables;
            _ = FishingSpots;
        }
    }
}