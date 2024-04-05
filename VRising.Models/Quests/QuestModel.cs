using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VRising.Localization;
using VRising.Models.Constants;
using VRising.Models.Data;
using VRising.Models.Internal;
using VRising.Models.Localization;
using VRising.Models.RootModels;

namespace VRising.Models.Quests
{
    public class QuestModel : ModelBase, IModel
    {
        public RisingEntity Entity { get; set; }


        public int QuestId { get; set; }
        public int Id => QuestId;
        public int Rarity => 99;
        public string Icon => null;
        public string PrefabName { get; set; }
        public string BasePath => BasePaths.Quests;
        public int RewardId { get; set; }
        public int DependencyId { get; set; }
        public TechUnlocks TechUnlocks { get; set; }
        public HashSet<int> QuestSubTaskEntryIds { get; set; }

        [JsonIgnore]
        public List<QuestSubTaskModel> SubTasks => QuestSubTaskEntryIds.Select(id => Database.Current.QuestSubTasks[id]).ToList();

        public LocalizedResource LocalizedName { get; set; }
        public LocalizedResource LocalizedFlavor { get; set; }
    }
}