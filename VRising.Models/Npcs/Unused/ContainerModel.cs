//using System.Collections.Generic;
//using System.Linq;
//using Newtonsoft.Json;
//using VRising.Models.Builders;
//using VRising.Models.Constants;
//using VRising.Models.Data;
//using VRising.Models.Drops;
//using VRising.Models.Helpers;
//using VRising.Models.Internal;
//using VRising.Models.RootModels;

//namespace VRising.Models.Npcs
//{
//    public class ContainerModel : ModelBase, IModel
//    {
//        private readonly LazyProperty<List<ItemDropChance>> _dropChances = new LazyProperty<List<ItemDropChance>>();

//        public RisingEntity Entity { get; set; }

//        public int ContainerId { get; set; }

//        public int Id => ContainerId;
//        public int Rarity => 0;
//        public string Name { get; set; }

//        public string PrefabName { get; set; }
//        public string BasePath => BasePaths.Containers;

//        public string Icon { get; set; }


//        [JsonIgnore]
//        public List<DropTableModel> DropTables
//        {
//            get
//            {
//                var results = new List<DropTableModel>();

//                if (!Database.Current.DropSources.TryGetValue(ContainerId, out var dropSourceModel))
//                {
//                    return results;
//                }

//                foreach (var sourceDropTable in dropSourceModel.DropTables)
//                {
//                    if (Database.Current.DropTables.TryGetValue(sourceDropTable.DropTableId, out var dropTable))
//                    {
//                        results.Add(dropTable);
//                    }
//                }

//                return results;
//            }
//        }

//        [JsonIgnore]
//        public List<ItemDropChance> DropChances
//        {
//            get
//            {
//                if (!_dropChances.Initialized)
//                {
//                    _dropChances.Value = DropTables.Select(d => d.DropTableId)
//                        .SelectMany(d => Database.Current.DropTables[d].DropChances)
//                        .ToList();
//                }

//                return _dropChances.Value;
//            }
//        }

//        public static ContainerModel FromEntity(RisingEntity entity)
//        {
//            return new ContainerModelBuilder().Build(entity);
//        }
//    }
//}