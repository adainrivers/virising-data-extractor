using System;
using System.Collections.Generic;
using VRising.Models.Internal;

namespace VRising.Models
{
    public abstract class DatabaseDictionary<T> : Dictionary<int, T>
    {
        protected void Populate(IEnumerable<int> entityIds, Func<RisingEntity, T> factory, Func<T, bool> validFunction = null)
        {
            foreach (var entityId in entityIds)
            {
                var model = factory(Database.Current.Entities[entityId]);
                if (validFunction != null && !validFunction(model))
                {
                    continue;
                }
                this[entityId] = model;
            }
        }
    }
}