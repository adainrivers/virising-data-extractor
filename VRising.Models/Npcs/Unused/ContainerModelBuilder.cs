//using VRising.Models.Helpers;
//using VRising.Models.Internal;
//using VRising.Models.Npcs;

//namespace VRising.Models.Builders
//{
//    internal class ContainerModelBuilder
//    {
//        public ContainerModel Build(RisingEntity entity)
//        {
//            var model = new ContainerModel
//            {
//                Entity = entity,
//                ContainerId = entity.PrefabGuid,
//                PrefabName = entity.PrefabName,
//                Name = PrefabNameCleaner.GetName(entity.PrefabName) ?? entity.PrefabName
//            };

//            return model;
//        }
//    }
//}