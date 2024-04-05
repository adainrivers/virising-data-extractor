using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace VRising.Models.Helpers
{
    public class PrefabNameCleaner
    {
        private static readonly HashSet<string> BadWords = new HashSet<string>
        {
            "Stage", "Breakable", "T", "Full", "Object", "DLCVariant", "Servant", "Lock", "DLC", "Resource", "Standard",
            "a", "b", "Var", "Placeable", "AB", "Ability", "Group"
        };
        public static string GetName(string prefabName)
        {
            var name = prefabName;

            if (name.StartsWith("CHAR_"))
            {
                name = name.Remove(0, 5);
            }
            if (name.StartsWith("TM_EH_"))
            {
                name = name.Remove(0, 6);
            }
            if (name.StartsWith("EH_") || name.StartsWith("GM_") || name.StartsWith("TM_") || name.StartsWith("DT_") || name.StartsWith("DG_"))
            {
                name = name.Remove(0, 3);
            }

            name = Regex.Replace(name, "[0-9]+", string.Empty);
            name = name.Replace("_", " ");
            var reg = new Regex(@"[A-Z]+");
            name = reg.Replace(name, m => " " + m.Value);
            name = name.Replace("Ao E", "AoE");
            var words = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            name = string.Join(' ', words.Where(w => !BadWords.Contains(w)));

            //switch (entityModel.MainCategory)
            //{
            //    case MainEntityCategory.Resource when Regex.IsMatch(unitName, "tm_rock.*_resource"):
            //        return "Rock";
            //    case MainEntityCategory.Resource when Regex.IsMatch(unitName, "tm_quartz.*_resource"):
            //        return "Quartz";
            //    case MainEntityCategory.Resource when Regex.IsMatch(unitName, "tm_iron.*_resource"):
            //        return "Iron Vein";
            //    case MainEntityCategory.Resource when Regex.IsMatch(unitName, "tm_sulfur.*_resource"):
            //        return "Sulphur Vein";
            //    case MainEntityCategory.Structure:
            //        break;
            //}

            return name;
        }
    }
}
