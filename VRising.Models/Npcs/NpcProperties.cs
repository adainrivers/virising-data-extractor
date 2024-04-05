using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Abilities;
using VRising.Models.Data;
using VRising.Models.Drops;

namespace VRising.Models.Npcs
{
    internal class NpcProperties
    {
        private readonly NpcModel _model;

        public Lazy<bool> Display { get; }
        public Lazy<List<DropTableModel>> DropTables { get; }
        public Lazy<List<ItemDropChance>> DropChances { get; }
        public Lazy<List<AbilityGroupModel>> AbilityGroups { get; }

        internal NpcProperties(NpcModel model)
        {
            _model = model;
            Display = new Lazy<bool>(GetDisplay);
            DropTables = new Lazy<List<DropTableModel>>(GetDropTables);
            DropChances = new Lazy<List<ItemDropChance>>(GetDropChances);
            AbilityGroups = new Lazy<List<AbilityGroupModel>>(GetAbilityGroups);
        }

        private List<AbilityGroupModel> GetAbilityGroups()
        {
            return _model.AbilityGroupIds.Where(id => Database.Current.AbilityGroups.ContainsKey(id))
                .Select(id => Database.Current.AbilityGroups[id]).ToList();
        }

        private List<ItemDropChance> GetDropChances()
        {
            return _model.DropTables.Select(d => d.DropTableId)
                .SelectMany(d => Database.Current.DropTables[d].DropChances)
                .ToList();
        }

        private List<DropTableModel> GetDropTables()
        {
            var dropTables = new List<DropTableModel>();

            if (!Database.Current.DropSources.TryGetValue(_model.NpcId, out var dropSourceModel))
            {
                return dropTables;
            }

            foreach (var sourceDropTable in dropSourceModel.DropTables)
            {
                if (Database.Current.DropTables.TryGetValue(sourceDropTable.DropTableId, out var dropTable))
                {
                    dropTables.Add(dropTable);
                }
            }
            return dropTables;
        }

        private bool GetDisplay()
        {
            if (_model.Id == 2139023341)
            {

            }

            if (_model.LocalizedName.Text == null) return false;
            if (Guid.TryParse(_model.LocalizedName.Text, out _)) return false;
            if (_model.LocalizedDescription.Text == null || Guid.TryParse(_model.LocalizedDescription.Text, out _)) return false;
            if(_model.BloodType?.TypeName == "VBlood" && _model.Icon == null) return false;

            return true;
        }
    }
}
