//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Converters;
//using VRising.Models.Builders;
//using VRising.Models.Data;
//using VRising.Models.Drops;
//using VRising.Models.Enums;
//using VRising.Models.Helpers;
//using VRising.Models.Internal;
//using VRising.Models.RootModels;

//namespace VRising.Models.Npcs
//{
//    public class ResourceModel : ModelBase
//    {
//        private readonly LazyProperty<List<ItemDropChance>> _dropChances = new LazyProperty<List<ItemDropChance>>();

//        public RisingEntity Entity { get; set; }

//        public int ResourceId { get; set; }

//        [JsonConverter(typeof(StringEnumConverter))]
//        public MaterialCategory MaterialCategory { get; set; }

//        public string Name { get; set; }

//        public string Description { get; set; }

//        public string PrefabName { get; set; }


//        public float Health { get; set; }

//        public int Level { get; set; }

//        public string Icon { get; set; }

//        public Guid NameKey { get; set; }

//        public Guid DescriptionKey { get; set; }


//        [JsonIgnore]
//        public List<DropTableModel> DropTables
//        {
//            get
//            {
//                var results = new List<DropTableModel>();

//                if (!Database.Current.DropSources.TryGetValue(ResourceId, out var dropSourceModel))
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

//        public static ResourceModel FromEntity(RisingEntity entity)
//        {
//            return new ResourceModelBuilder().Build(entity);
//        }
//    }
//}