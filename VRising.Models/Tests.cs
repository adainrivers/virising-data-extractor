using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace VRising.Models
{
    public static class Tests
    {

        public static void RunTests()
        {
            //var units = Database.Current.Npcs.Values.Where(u => u.FactionId == 1522496317).Select(u => u.Name).ToList();
            //var servantPerks = Database.Current.ServantPerks.Values.ToList();
            //var servantMissions = Database.Current.ServantMissions.Values.ToList();

            //var npcs = Database.Current.Npcs.Values.Where(n => n.Display).Select(
            //    n => new { n.Id, Name= n.LocalizedName.Text, n.PrefabName, n.Level, BloodType = n.BloodType?.TypeName }).ToList();

            //var sb = new StringBuilder();
            //foreach (var npc in npcs)
            //{
            //    sb.AppendLine($"{npc.Id}\t{npc.Name}\t{npc.PrefabName}\t{npc.Level}\t{npc.BloodType}");
            //}
            //File.WriteAllText("npcs.tsv", sb.ToString());

            //var items = Database.Current.Items.Values.Where(n => n.Display).Select(n => new { n.Id, Name = n.LocalizedName.Text, n.PrefabName, n.Rarity, n.Obtainable }).ToList();
            //sb = new StringBuilder();
            //foreach (var item in items)
            //{
            //    sb.AppendLine($"{item.Id}\t{item.Name}\t{item.PrefabName}\t{item.Rarity}\t{item.Obtainable}");
            //}
            //File.WriteAllText("items.tsv", sb.ToString());

            var items = new Items
            {
                Weapons = Database.Current.Items.Weapons.Where(n => n.Display).Select(n => n.Id).ToHashSet()
            };
            File.WriteAllText("weapons.txt", string.Join(",",items.Weapons));
        }

        private class Items
        {
            public HashSet<int> Weapons { get; set; }
            public HashSet<int> Armours { get; set; }
            public HashSet<int> Cloaks { get; set; }
            public HashSet<int> Headgear { get; set; }
        }
    }
}
