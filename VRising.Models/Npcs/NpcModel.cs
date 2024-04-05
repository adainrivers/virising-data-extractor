using System;
using System.Collections.Generic;
using VRising.Localization;
using VRising.Models.Abilities;
using VRising.Models.BloodTypes;
using VRising.Models.Constants;
using VRising.Models.Data;
using VRising.Models.Drops;
using VRising.Models.Enums;
using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;
using VRising.Models.RootModels;
using VRising.Models.UnitLocations.Models;

namespace VRising.Models.Npcs
{
    public class NpcModel : ModelBase, IModel
    {
        private readonly NpcProperties _properties;

        public NpcModel()
        {
            _properties = new NpcProperties(this);
        }

        public List<int> AbilityGroupIds { get; set; }
        public List<AbilityGroupModel> AbilityGroups => _properties.AbilityGroups.Value;
        public int? AsServantId { get; set; }
        public bool BloodCanBeConsumed { get; set; }
        public PrefabType BloodPrefabType { get; set; }
        public BloodTypeModel BloodType => Database.Current.BloodTypes.GetOrNull(BloodTypeId);
        public int BloodTypeId { get; set; }

        public bool Display => _properties.Display.Value;
        public List<ItemDropChance> DropChances => _properties.DropChances.Value;
        public DropSourceModel DropSource => Database.Current.DropSources.GetOrNull(NpcId);
        public List<DropTableModel> DropTables => _properties.DropTables.Value;
        public int EnemyColorTeamIndex { get; set; }
        public RisingEntity Entity { get; set; }
        public float Health { get; set; }
        public bool IsServant { get; set; }
        public int Level { get; set; }
        public MapInfo MapInfo { get; set; }
        public int NpcId { get; set; }
        public PrefabType PrefabType { get; set; }
        public ResistanceData ResistanceData { get; set; }
        public TeamType TeamType { get; set; }
        public TechUnlocks TechUnlocks { get; set; }
        public UnitCategory UnitCategory { get; set; }
        public UnitStats UnitStats { get; set; }
        public bool VBloodNpc { get; set; }
        public int Id => NpcId;
        public int Rarity => 99;

        public string PrefabName { get; set; }
        public string BasePath => BasePaths.Npc;
        public string Icon { get; set; }
        public int FactionId { get; set; }
        public LocalizedResource LocalizedName { get; set; }
        public LocalizedResource LocalizedDescription { get; set; }

        public UnitCoords UnitCoords => Database.Current.UnitLocations.GetOrNull(NpcId);
    }
}