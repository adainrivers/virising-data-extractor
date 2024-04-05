using System;
using System.Collections.Generic;
using System.Linq;

namespace VRising.Models
{
    public class DatabaseMappings
    {
        private readonly Database _database;
        private ILookup<int, int> _techItemTechMap;

        public DatabaseMappings(Database database)
        {
            _database = database;
        }

        public Dictionary<int, HashSet<int>> ItemDropTableMap { get; set; } = new Dictionary<int, HashSet<int>>();
        public Dictionary<int, HashSet<int>> AbilityGroupUnitMap { get; set; } = new Dictionary<int, HashSet<int>>();
        public Dictionary<string, int> ItemPrefabNameEntityIdMap { get; set; } = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, int> UnitPrefabNameEntityIdMap { get; set; } = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, int> RecipePrefabNameEntityIdMap { get; set; } = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, int> ResearchStationPrefabNameEntityIdMap { get; set; } = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, int> WorkstationPrefabNameEntityIdMap { get; set; } = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, int> AbilityGroupPrefabNameEntityIdMap { get; set; } = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, int> BlueprintPrefabNameEntityIdMap { get; set; } = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, int> QuestPrefabNameEntityIdMap { get; set; } = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, int> ServantMissionPrefabNameEntityIdMap { get; set; } = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, int> ServantPerkPrefabNameEntityIdMap { get; set; } = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, int> ServantNpcPrefabNameEntityIdMap { get; set; } = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public ILookup<string, int> PrefabEntityMap { get; set; }
        public ILookup<int, int> TechItemTechMap => _techItemTechMap ??= GetTechItemTechMap();

        private ILookup<int, int> GetTechItemTechMap()
        {
            var techEntities = _database.ComponentTypeToEntitiesMap["TechItemRequirementBuffer"].Select(id => _database.Entities[id])
                .Where(e => e.TechItemRequirementBuffer != null && e.TechItemRequirementBuffer.Count == 1);
            return techEntities.ToLookup(e => e.TechItemRequirementBuffer[0].Guid, e=>e.PrefabGuid);
        }
    }
}