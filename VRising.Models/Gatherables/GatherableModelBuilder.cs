using VRising.Models.Internal;

namespace VRising.Models.Gatherables
{
    internal class GatherableModelBuilder
    {
        public GatherableModel Build(RisingEntity entity)
        {
            var model = new GatherableModel
            {
                Entity = entity,
                GatherableId = entity.PrefabGuid,
                PrefabName = entity.PrefabName,
            };

            return model;
        }
    }
}