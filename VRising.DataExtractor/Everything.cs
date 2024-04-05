using System.Collections.Generic;

namespace VRising.DataExtractor
{
    public class Everything
    {
        public Dictionary<int, Dictionary<string, object>> Entities;
        public Dictionary<string, HashSet<int>> ComponentTypeToEntitiesMap;
    }
}
