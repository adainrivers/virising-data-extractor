using System;
using VRising.Models.Constants;

namespace VRising.DataExtractor
{
    public static class RecipeManipulator
    {
        public static void AddRecipeToUser(int recipeId)
        {
            var world = new WorldHelper();
            var defaultUser = world.PrefabCollection.PrefabLookupMap[new PrefabGUID(KnownEntities.User)];
            if (world.EntityManager.TryGettingBuffer<WorkstationRecipesBuffer>(defaultUser, out var recipesBuffer))
            {
                try
                {
                    recipesBuffer.Add(new WorkstationRecipesBuffer { RecipeGuid = new PrefabGUID(recipeId) });
                    Plugin.Logger.LogInfo("Added.");
                }
                catch (Exception e)
                {
                    Plugin.Logger.LogWarning("Could not add the recipe.");
                }
            }
            else
            {
                Plugin.Logger.LogWarning("Could not find the user's recipe data.");
            }
        }
    }
}