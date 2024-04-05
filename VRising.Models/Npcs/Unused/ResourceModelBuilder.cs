//using System;
//using VRising.Models.Enums;
//using VRising.Models.Helpers;
//using VRising.Models.Internal;
//using VRising.Models.Npcs;

//namespace VRising.Models.Builders
//{
//    internal class ResourceModelBuilder
//    {
//        public ResourceModel Build(RisingEntity entity)
//        {
//            var model = new ResourceModel
//            {
//                Entity = entity,
//                ResourceId = entity.PrefabGuid,
//                PrefabName = entity.PrefabName,
//                Name = PrefabNameCleaner.GetName(entity.PrefabName) ?? entity.PrefabName
//            };

//            if (entity.EntityCategory != null)
//            {
//                model.MaterialCategory = Enum.Parse<MaterialCategory>(entity.EntityCategory.MaterialCategory);
//            }

//            if (entity.Health != null)
//            {
//                model.Health = (float)entity.Health.MaxHealth;
//            }

//            if (entity.UnitLevel != null)
//            {
//                model.Level = entity.UnitLevel.Level;
//            }

//            return model;
//        }
//    }
//}