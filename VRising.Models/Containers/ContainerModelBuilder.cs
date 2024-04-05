using VRising.Models.Internal;

namespace VRising.Models.Containers
{
    internal class ContainerModelBuilder
    {
        public ContainerModel Build(RisingEntity entity)
        {
            var model = new ContainerModel
            {
                Entity = entity,
                ContainerId = entity.PrefabGuid,
                PrefabName = entity.PrefabName,
            };

            return model;
        }
    }
}