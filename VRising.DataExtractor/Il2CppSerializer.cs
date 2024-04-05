using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Newtonsoft.Json.Linq;
using Stunlock.Localization;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace VRising.DataExtractor
{
    public class Il2CppSerializer
    {
        private const int MaxDepth = 5;

        public string Serialize(object value)
        {
            var result = GetSerializedValue(value);
            return result.ToString();
        }

        private static readonly HashSet<Type> PrimitiveTypes = new()
        {
            typeof(decimal),
            typeof(string),
        };

        private object GetSerializedValue(object value, int depth = 0)
        {
            if (depth == MaxDepth || value == null)
            {
                return null;
            }

            var t = value.GetType();

            if (t.IsPrimitive || PrimitiveTypes.Contains(t))
            {
                return value;
            }

            if (t.IsEnum)
            {
                return value.ToString();
            }

            if (t == typeof(PrefabGUID))
            {
                return ((PrefabGUID)value).GuidHash;
            }

            if (t == typeof(LocalizationKey))
            {
                var key = (LocalizationKey)value;
                return new JObject(new JProperty("Key", key.Key.ToGuid().ToSystemGuid()), new JProperty("Text", key.ToString()));
            }

            if (t == typeof(FixedString64))
            {
                return value.ToString();
            }

            if (t == typeof(FixedString128))
            {
                return value.ToString();
            }

            if (t == typeof(AssetGuid))
            {
                var assetGuid = (AssetGuid)value;
                try
                {
                    var localizationKey = new LocalizationKey(assetGuid);
                    return GetSerializedValue(localizationKey);
                }
                catch (Exception)
                {
                    // ignored
                }

                return assetGuid.ToGuid().ToSystemGuid();
            }

            if (t == typeof(Sprite))
            {
                return ((Sprite)value).name;
            }

            if (t == typeof(float3))
            {
                var f3 = (float3)value;
                return new JObject(
                    new JProperty(nameof(f3.x), f3.x),
                    new JProperty(nameof(f3.y), f3.y),
                    new JProperty(nameof(f3.z), f3.z)
                );
            }

            if (t == typeof(ModifiableBool))
            {
                return ((ModifiableBool)value)._Value;
            }

            if (t == typeof(ModifiableFloat))
            {
                return ((ModifiableFloat)value)._Value;
            }

            if (t == typeof(ModifiableFloat3))
            {
                return GetSerializedValue(((ModifiableFloat3)value)._Value);
            }

            if (t == typeof(ModifiableInt))
            {
                return ((ModifiableInt)value)._Value;
            }

            if (t == typeof(ModifiablePrefabGUID))
            {
                return GetSerializedValue(((ModifiablePrefabGUID)value)._Value);
            }

            if (value is IDictionary dItems)
            {
                var items = new JObject();
                foreach (var key in dItems.Keys)
                {
                    items.Add(new JProperty(key.ToString(), GetSerializedValue(dItems[key], depth)));
                }

                return items;
            }

            if (value is IEnumerable eItems)
            {
                var items = new JArray();
                foreach (var item in eItems)
                {
                    items.Add(GetSerializedValue(item, depth));
                }

                if (items.Count > 0)
                {
                    return items;
                }

                return null;
            }

            var result = new JObject();
            var fields = value.GetType().GetFields();
            foreach (var fieldInfo in fields)
            {
                var fieldValue = fieldInfo.GetValue(value);

                try
                {
                    var serializedValue = GetSerializedValue(fieldValue, depth + 1);
                    result.Add(new JProperty(fieldInfo.Name, serializedValue));
                }
                catch (Exception)
                {
                    Plugin.Logger.LogWarning($"Can't serialize field {fieldInfo.DeclaringType?.FullName}.{fieldInfo.Name}");
                }
            }

            var properties = value.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                try
                {
                    if (propertyInfo.GetIndexParameters().Length > 0)
                    {
                        continue;
                    }

                    var callerCountAttribute = propertyInfo.GetMethod.GetCustomAttribute<CallerCountAttribute>();
                    if (callerCountAttribute == null || callerCountAttribute.Count == 0)
                    {
                        continue;
                    }

                    var propertyValue = propertyInfo.GetValue(value);

                    var serializedValue = GetSerializedValue(propertyValue, depth + 1);
                    result.Add(new JProperty(propertyInfo.Name, serializedValue));
                }
                catch (Exception)
                {
                    Plugin.Logger.LogWarning($"Can't serialize property {propertyInfo.DeclaringType?.FullName}.{propertyInfo.Name}");
                }
            }

            return result;
        }
    }
}