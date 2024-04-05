using System;
using System.Collections.Generic;

namespace VRising.Models.Helpers
{
    public static class Extensions
    {
        public static void AddRange<T>(this HashSet<T> hashSet, IEnumerable<T> values)
        {
            foreach (var value in values)
            {
                hashSet.Add(value);
            }
        }

        public static Dictionary<TKey, TValue> ToDictionarySafe<T, TKey, TValue>(this IEnumerable<T> enumerable, Func<T, TKey> keySelector, Func<T, TValue> valueSelector)
        {
            var result = new Dictionary<TKey, TValue>();
            foreach (var item in enumerable)
            {
                result[keySelector(item)] = valueSelector(item);
            }
            return result;
        }

        public static Dictionary<TKey, T> ToDictionarySafe<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keySelector)
        {
            var result = new Dictionary<TKey, T>();
            foreach (var item in enumerable)
            {
                result[keySelector(item)] = item;
            }
            return result;
        }

    }
}