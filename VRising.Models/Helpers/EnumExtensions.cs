using System;
using System.Collections.Generic;
using System.Linq;

namespace VRising.Models.Helpers
{
    public static class EnumExtensions
    {
        public static IEnumerable<T> GetUniqueFlags<T>(this T flags)
            where T : Enum
        {
            return Enum.GetValues(flags.GetType())
                .Cast<Enum>()
                .Where(flags.HasFlag)
                .Select(value => (T)value);
        }

        public static Guid ToGuid(this string value)
        {
            return value == null ? Guid.Empty : Guid.Parse(value);
        }
    }
}