using System;
using VRising.Models.Internal;
using VRising.Models.Localization;

namespace VRising.Models.Fishing
{
    internal class FishingSpotModelBuilder
    {
        public FishingSpotModel Build(RisingEntity entity)
        {
            var model = new FishingSpotModel
            {
                Entity = entity,
                FishingSpotId = entity.PrefabGuid,
                PrefabName = entity.PrefabName,
                LocalizedName = new LocalizedResource(Guid.Empty.ToString(), "Fishing Spot")
            };

            return model;
        }
    }
}