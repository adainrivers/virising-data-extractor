using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VRising.Models.Data;
using VRising.Models.Internal;
using VRising.Models.RootModels;

namespace VRising.Models.Items
{
    public class ItemSetModel : ModelBase
    {
        public RisingEntity Entity { get; set; }

        public int ItemSetId { get; set; }
        public List<ItemSetBuff> SetBonusses { get; set; }
        public HashSet<int> ItemGuids { get; set; }
        public string Name { get; set; }
        public Guid NameKey { get; set; }

        [JsonIgnore]
        public List<ItemModel> Items => ItemGuids.Select(id => Database.Current.Items[id]).ToList();

        public string PrefabName { get; set; }

        public static ItemSetModel FromEntity(RisingEntity entity)
        {
            return new ItemSetModelBuilder().Build(entity);
        }
    }
}