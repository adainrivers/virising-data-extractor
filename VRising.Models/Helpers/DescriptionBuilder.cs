using System.Collections.Generic;
using VRising.Models.Internal;

namespace VRising.Models.Helpers
{
    internal static class DescriptionBuilder
    {
        public static string BuildDescription(this string format,
            IList<RisingDb_LocalizedStringBuilderParameter> parameters)
        {
            if (format == null || parameters == null)
            {
                return format;
            }

            foreach (var parameter in parameters)
            {
                format = format.Replace("{" + parameter.Key + "}", parameter.Value);
            }

            return format;
        }
    }
}