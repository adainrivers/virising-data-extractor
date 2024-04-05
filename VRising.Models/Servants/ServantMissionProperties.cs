using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Data;
using VRising.Models.Drops;

namespace VRising.Models.Servants
{
    internal class ServantMissionProperties
    {
        private readonly ServantMissionModel _model;
        public Lazy<List<DropTableModel>> DropTables { get; }
        public Lazy<List<ItemDropChance>> DropChances { get; }

        internal ServantMissionProperties(ServantMissionModel model)
        {
            _model = model;
            DropTables = new Lazy<List<DropTableModel>>(GetDropTables);
            DropChances = new Lazy<List<ItemDropChance>>(GetDropChances);
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

            if (!Database.Current.DropSources.TryGetValue(_model.ServantMissionId, out var dropSourceModel))
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
    }
}