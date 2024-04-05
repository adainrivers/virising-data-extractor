global using Bloodstone.API;
global using ProjectM;
using System.Collections.Generic;
using Unity.Entities;
using WorldType = VRising.Configuration.WorldType;

namespace VRising.DataExtractor
{
    internal class WorldHelper
    {
        //public static WorldHelper Client = new WorldHelper(WorldType.Client);
        //public static WorldHelper Server = new WorldHelper(WorldType.Server);
        //public WorldHelper(WorldType worldType)
        //{
        //    WorldType = worldType;
        //    GameWorld = GetWorld(worldType);
        //    EntityManager = GameWorld.EntityManager;
        //    PrefabCollection = GameWorld.GetExistingSystem<PrefabCollectionSystem>();
        //    GameData = GameWorld.GetExistingSystem<GameDataSystem>();

        //    foreach (var kv in PrefabCollection.PrefabNameLookupMap)
        //    {
        //        PrefabNames[kv.Key.GuidHash] = kv.Value.ToString();
        //    }
        //}

        public WorldHelper()
        {
            WorldType = VWorld.IsClient ? WorldType.Client : WorldType.Server;
            GameWorld = VWorld.IsClient ? VWorld.Client : VWorld.Server;
            EntityManager = GameWorld.EntityManager;
            PrefabCollection = GameWorld.GetExistingSystem<PrefabCollectionSystem>();
            GameData = GameWorld.GetExistingSystem<GameDataSystem>();

            foreach (var kv in PrefabCollection.PrefabGuidToNameDictionary)
            {
                PrefabNames[kv.Key.GuidHash] = kv.Value.ToString();
            }
        }

        public WorldHelper(World world)
        {
            WorldType = VWorld.IsClient ? WorldType.Client : WorldType.Server;
            GameWorld = world;
            EntityManager = GameWorld.EntityManager;
            PrefabCollection = GameWorld.GetExistingSystem<PrefabCollectionSystem>();
            GameData = GameWorld.GetExistingSystem<GameDataSystem>();

            foreach (var kv in PrefabCollection.PrefabGuidToNameDictionary)
            {
                PrefabNames[kv.Key.GuidHash] = kv.Value.ToString();
            }
        }

        public World GameWorld { get; }
        public WorldType WorldType { get; }

        public GameDataSystem GameData { get; }

        public PrefabCollectionSystem PrefabCollection { get; }

        public EntityManager EntityManager { get; }

        public Dictionary<int, string> PrefabNames { get; } = new Dictionary<int, string>();

        //private static World GetWorld(WorldType worldType)
        //{
        //    var name = worldType == WorldType.Server ? "Server" : "Client_0";
        //    foreach (var world in World.All)
        //    {
        //        Plugin.Logger.LogInfo($"Found world {world.Name}");
        //        if (world.Name == name)
        //        {
        //            return world;
        //        }
        //    }

        //    throw new Exception("Could not find the world.");
        //}
    }
}