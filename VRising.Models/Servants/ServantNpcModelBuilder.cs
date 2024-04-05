using VRising.Models.Helpers;
using VRising.Models.Internal;
using VRising.Models.Localization;

namespace VRising.Models.Servants
{
    internal class ServantNpcModelBuilder
    {
        public ServantNpcModel Build(RisingEntity entity)
        {
            var model = new ServantNpcModel
            {
                Entity = entity,
                ServantNpcId = entity.PrefabGuid,
                PrefabName = entity.PrefabName
            };
            if (entity.ManagedCharacterHUD != null)
            {
                model.LocalizedName = new LocalizedResource(entity.ManagedCharacterHUD.Name.Key,
                    entity.ManagedCharacterHUD.Name.Text);

                model.LocalizedDescription = new LocalizedResource(entity.ManagedCharacterHUD.Description.Key,
                    entity.ManagedCharacterHUD.Description.Text);

                model.Icon = entity.ManagedCharacterHUD.Icon;
            }
            

            return model;
        }
    }
}