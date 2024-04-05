using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Constants;
using VRising.Models.Enums;

namespace VRising.Models.Npcs
{
    public class DatabaseNpcs : DatabaseDictionary<NpcModel>
    {
        private static DatabaseNpcs _instance;
        public static DatabaseNpcs Instance => _instance ??= new DatabaseNpcs();

        public List<NpcModel> VBloods { get; set; }
        public List<NpcModel> Brutes { get; set; }
        public List<NpcModel> Creatures { get; set; }
        public List<NpcModel> Rogues { get; set; }
        public List<NpcModel> Scholars { get; set; }
        public List<NpcModel> Warriors { get; set; }
        public List<NpcModel> Workers { get; set; }
        public List<NpcModel> Servants { get; set; }
        public List<NpcModel> Other { get; set; }

        public IEnumerable<NpcModel> All => VBloods.Union(Brutes).Union(Creatures).Union(Rogues).Union(Scholars).Union(Warriors).Union(Workers).Union(Other);


        private DatabaseNpcs()
        {
            var category = MainEntityCategory.Unit.ToString();
            var builder = new NpcModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["EntityCategory"]
                .Where(id => Database.Current.Entities[id].EntityCategory.MainCategory == category)
                .Union(new List<int> { KnownEntities.User });
            Populate(entityIds, builder.Build, m => m.PrefabName.StartsWith("CHAR_") && !m.PrefabName.EndsWith("_Servant") && m.Level != 0 && m.PrefabName != null && m.LocalizedName != null && m.LocalizedName.Text != null && !Guid.TryParse(m.LocalizedName.Text, out _));

            var visibleNpcs = Values.Where(n => n.Display).ToList();

            VBloods = visibleNpcs.Where(i => i.BloodType is { TypeName: "VBlood" })
                .OrderByDescending(i => i.Level).ToList();

            Brutes = visibleNpcs.Where(i => i.BloodType is { TypeName: "Brute" })
                .OrderByDescending(i => i.Level).ToList();

            Creatures = visibleNpcs.Where(i => i.BloodType is { TypeName: "Creature" })
                .OrderByDescending(i => i.Level).ToList();

            Workers = visibleNpcs.Where(i => i.BloodType is { TypeName: "Worker" })
                .OrderByDescending(i => i.Level).ToList();

            Warriors = visibleNpcs.Where(i => i.BloodType is { TypeName: "Warrior" })
                .OrderByDescending(i => i.Level).ToList();

            Rogues = visibleNpcs.Where(i => i.BloodType is { TypeName: "Rogue" })
                .OrderByDescending(i => i.Level).ToList();

            Scholars = visibleNpcs.Where(i => i.BloodType is { TypeName: "Scholar" })
                .OrderByDescending(i => i.Level).ToList();

            Servants = visibleNpcs.Where(i => i.IsServant)
                .OrderByDescending(i => i.Level).ToList();

            Other = visibleNpcs.Where(i => !i.IsServant && i.BloodType == null)
                .OrderByDescending(i => i.Level).ToList();


        }
    }
}