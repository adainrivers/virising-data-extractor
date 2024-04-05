using System;
using VRising.Models.Enums;
using VRising.Models.Internal;

namespace VRising.Models.Entities
{
    public class DatabaseCategorizedEntities : DatabaseDictionary<CategorizedEntityModel>
    {
        private static DatabaseCategorizedEntities _instance;
        public static DatabaseCategorizedEntities Instance => _instance ??= new DatabaseCategorizedEntities();

        private DatabaseCategorizedEntities()
        {
            var builder = new CategorizedEntityModelBuilder();
            var entityIds = Database.Current.ComponentTypeToEntitiesMap["EntityCategory"];
            Populate(entityIds, builder.Build);
        }
    }

    internal class CategorizedEntityModelBuilder
    {
        public CategorizedEntityModel Build(RisingEntity entity)
        {
            var model = new CategorizedEntityModel
            {
                Entity = entity,
                CategorizedEntityId = entity.PrefabGuid,
                PrefabName = entity.PrefabName
            };

            if (entity.EntityCategory != null)
            {
                model.MainCategory = Enum.Parse<MainEntityCategory>(entity.EntityCategory.MainCategory);
                model.UnitCategory = Enum.Parse<UnitCategory>(entity.EntityCategory.UnitCategory);
                model.StructureCategory = Enum.Parse<StructureCategory>(entity.EntityCategory.StructureCategory);
                model.MaterialCategory = Enum.Parse<MaterialCategory>(entity.EntityCategory.MaterialCategory);
            }

            return model;
        }
    }
}