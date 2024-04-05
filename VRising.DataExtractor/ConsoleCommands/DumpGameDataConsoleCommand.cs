//using System;
//using Engine.Console;
//using Il2CppInterop.Runtime.Injection;
//using ProjectM;
//using UnhollowerRuntimeLib;

//namespace VRising.DataExtractor.ConsoleCommands;

////Extend DefaultConsoleCommand since abstract classes cannot be used
//public class DumpGameDataConsoleCommand : DefaultConsoleCommand
//{
//    //Required for Il2Cpp internals
//    public DumpGameDataConsoleCommand(IntPtr ptr) : base(ptr) { }

//    //Required to create object from C#
//    public DumpGameDataConsoleCommand() : base(ClassInjector.DerivedConstructorPointer<DumpGameDataConsoleCommand>())
//    {
//        ClassInjector.DerivedConstructorBody(this);
//    }

//    //Method parameters correspond to command arguments
//    public void Execute()
//    {
//        Plugin.Logger.LogMessage($"Starting to execute {nameof(DumpGameDataConsoleCommand)}.");
//        //if (arg1 == "e")
//        //{
//        //DatabaseBuilder.GetBuildMenuComposition();
//        DatabaseBuilder.DumpPrefabs();
//        //DatabaseBuilder.DumpEverything();
//        //DatabaseBuilder.DumpAbsolutelyEverything();
//        //DatabaseBuilder.DumpAllComponentTypes();
//        //DatabaseBuilder.DumpCoords();
//        //}
//        //else
//        //{
//        //    DatabaseBuilder.Dump();
//        //}

//        Plugin.Logger.LogMessage($"{nameof(DumpGameDataConsoleCommand)} has been executed.");
//    }

//    public void Register(ConsoleCommandSystem system)
//    {
//        //Method to call when command is run
//        var executingMethod = UnhollowerRuntimeLib.Il2CppType.Of<DumpGameDataConsoleCommand>().GetMethod("Execute");
//        //Types of Action must match the executing method
//        var delegateType = UnhollowerRuntimeLib.Il2CppType.Of<Il2CppSystem.Action>();

//        system.RegisterCommand("dumpgamedata", "Dumps game data in json format", executingMethod.CreateDelegate(delegateType, this));

//        Plugin.Logger.LogMessage($"{nameof(DumpGameDataConsoleCommand)} is now registered.");
//    }
//}

