using System.Collections.Generic;
using System.Linq;

namespace VRising.Models.Helpers
{
    public static class  DatabaseExtensions
    {
        public static T GetOrNull<T>(this Dictionary<int, T> source, int key) where T : class
        {
            return source.TryGetValue(key, out var value) ? value : null;
        }

        public static List<T> ToNonNullList<T>(this IEnumerable<T> source) where T : class
        {
            return source.Where(i => i != null).ToList();
        }
    }
}
