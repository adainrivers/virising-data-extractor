using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VRising.Models.Containers;
using VRising.Models.Entities;
using VRising.Models.Enums;
using VRising.Models.Fishing;
using VRising.Models.Gatherables;
using VRising.Models.Helpers;
using VRising.Models.Items;
using VRising.Models.Npcs;
using VRising.Models.UnitLocations.Models;

namespace VRising.Models.Data
{
    public class UnitItemDropChance
    {
        public UnitItemDropChance(int unitId, int itemId, float dropChance, int quantity, DropTriggerType dropTrigger,
            RelicType relicType, int dropTableId)
        {
            UnitId = unitId;
            ItemId = itemId;
            DropChance = dropChance;
            Quantity = quantity;
            DropTrigger = dropTrigger;
            RelicType = relicType;
            DropTableId = dropTableId;
        }

        public int UnitId { get; }
        public int ItemId { get; set; }
        public float DropChance { get; set; }
        public int Quantity { get; set; }
        public DropTriggerType DropTrigger { get; }
        public RelicType RelicType { get; }
        public int DropTableId { get; }

        [JsonIgnore]
        public ItemModel Item => Database.Current.Items.ContainsKey(ItemId)
            ? Database.Current.Items[ItemId]
            : null;

        [JsonIgnore]
        public NpcModel Npc => Database.Current.Npcs.ContainsKey(UnitId)
            ? Database.Current.Npcs[UnitId]
            : null;

        [JsonIgnore]
        public ContainerModel Container => Database.Current.Containers.GetOrNull(UnitId);

        [JsonIgnore]
        public GatherableModel Gatherable => Database.Current.Gatherables.GetOrNull(UnitId);

        [JsonIgnore]
        public FishingSpotModel FishingSpot => Database.Current.FishingSpots.GetOrNull(UnitId);

        private HashSet<MapCoords> _coords;
        public HashSet<MapCoords> Coords => _coords ??= GetCoords();

        private HashSet<MapCoords> GetCoords()
        {
            if (Database.Current.UnitLocations.TryGetValue(UnitId, out var unitCoords))
            {
                return unitCoords.Coords.Where(c => c.DropTables != null && c.DropTables.ContainsKey(DropTableId))
                    .Select(c => new MapCoords(UnitId, c.X, c.Z)).ToHashSet(new MapCoordsComparer());
            }
            return new HashSet<MapCoords>();
        }

        //[JsonIgnore]
        //public ResourceModel Resource => Database.Current.Resources.ContainsKey(NpcId)
        //    ? Database.Current.Resources[NpcId]
        //    : null;

        //[JsonIgnore]
        //public ContainerModel Container => Database.Current.Containers.ContainsKey(NpcId)
        //    ? Database.Current.Containers[NpcId]
        //    : null;

        [JsonIgnore]
        public CategorizedEntityModel CategorizedEntity =>
            Database.Current.CategorizedEntities.ContainsKey(UnitId)
                ? Database.Current.CategorizedEntities[UnitId]
                : null;
    }
}