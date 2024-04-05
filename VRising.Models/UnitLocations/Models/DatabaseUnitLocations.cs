using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using VRising.Configuration;

namespace VRising.Models.UnitLocations.Models
{
    public class DatabaseUnitLocations : DatabaseDictionary<UnitCoords>
    {
        private static DatabaseUnitLocations _instance;
        public static DatabaseUnitLocations Instance => _instance ??= new DatabaseUnitLocations();

        private DatabaseUnitLocations()
        {
            var filePath = Path.Combine(AppConfig.DataFolder, "MapLog", "Coords.json");
            var json = File.ReadAllText(filePath);
            var dict = JsonConvert.DeserializeObject<Dictionary<int, UnitCoords>>(json);
            foreach (var (unitId, coords) in dict)
            {
                this[unitId] = coords;
            }
        }
    }
}
