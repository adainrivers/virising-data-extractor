using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using VRising.Models.Internal;
using VRising.Models.Items;
using VRising.Models.Npcs;
using Math = System.Math;

namespace VRising.Models.Data
{
    public class MapInfo
    {
        private static Dictionary<string, int> _categories = new Dictionary<string, int>();
        //public HashSet<int> CategoryIds { get; set; }
        public HashSet<int> LocationIds { get; set; }
        public int Zoom { get; set; }
        public int CategoryId { get; set; }

        private const int ClosestZoom = 12;
        private const int FurthestZoom = 9;
        private static MapGenieData _mapGenieData;

        public static void Initialize(string filePath)
        {
            _mapGenieData =
                JsonConvert.DeserializeObject<MapGenieData>(
                    File.ReadAllText(filePath));
            foreach (var dbLocation in _mapGenieData.locations)
            {
                dbLocation.title = Regex.Replace(dbLocation.title, "\\(\\d+\\)", string.Empty).Trim();

                if (dbLocation.category_id != 0)
                {
                    _categories[dbLocation.title] = dbLocation.category_id;
                }
            }
        }

        public static MapInfo FromItem(ItemModel item)
        {
            if (!item.Display)
            {
                return null;

            }
            return _categories.TryGetValue(item.LocalizedName.Text, out var categoryId)
                ? new MapInfo
                {
                    Zoom = 9,
                    CategoryId = categoryId
                }
                : null;
        }

        public static MapInfo FromUnit(NpcModel npc)
        {
            var locations = _mapGenieData.locations.Where(l => l.title == npc.LocalizedName?.Text).ToList();
            if (locations.Count == 0)
            {
                return null;
            }

            var mapInfo = new MapInfo
            {
                LocationIds = locations.Select(l => l.id).ToHashSet()
            };

            var coords = locations.Select(l => new Point { X = l.longitude, Y = l.latitude }).ToList();

            var max = 0d;
            foreach (var coord in coords)
            {
                foreach (var coord2 in coords)
                {
                    max = Math.Max(max, coord.Distance(coord2));
                }
            }

            //mapInfo.Zoom = (int)Math.Floor(12 - (max * 4));
            mapInfo.Zoom = 9;

            return mapInfo;
        }

        private class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public double Distance(Point other)
            {
                return Math.Abs(Math.Sqrt((Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2))));
            }

        }
    }
}
