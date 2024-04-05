// Auto Generated From New World Datasheets

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VRising.Models.Internal
{

    public class RisingDb_Entity_Self
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Parent
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Attach
    {

        [JsonProperty("Parent")]
        public RisingDb_Parent Parent { get; set; }
    }

    public class RisingDb_Owner
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_EntityOwner
    {

        [JsonProperty("Owner")]
        public RisingDb_Owner Owner { get; set; }
    }

    public class RisingDb__Entity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Creator
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity _Entity { get; set; }
    }

    public class RisingDb_EntityCreator
    {

        [JsonProperty("Creator")]
        public RisingDb_Creator Creator { get; set; }
    }

    public class RisingDb_Target
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Buff
    {

        [JsonProperty("Target")]
        public RisingDb_Target Target { get; set; }

        [JsonProperty("Stacks")]
        public int Stacks { get; set; }

        [JsonProperty("MaxStacks")]
        public int MaxStacks { get; set; }

        [JsonProperty("BuffType")]
        public string BuffType { get; set; }

        [JsonProperty("ResetAge")]
        public bool ResetAge { get; set; }

        [JsonProperty("IncreaseStacks")]
        public bool IncreaseStacks { get; set; }

        [JsonProperty("CorrectlyCreated")]
        public bool CorrectlyCreated { get; set; }

        [JsonProperty("StartTime")]
        public double StartTime { get; set; }
    }

    public class RisingDb_Target2
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_SpellTarget
    {

        [JsonProperty("Target")]
        public RisingDb_Target2 Target { get; set; }

        [JsonProperty("IsInteractableSpell")]
        public bool IsInteractableSpell { get; set; }

        [JsonProperty("DestroyIfNotInteractable")]
        public bool DestroyIfNotInteractable { get; set; }
    }

    public class RisingDb_DestroyData
    {

        [JsonProperty("DestroyReason")]
        public string DestroyReason { get; set; }

        [JsonProperty("DestroyDebugReason")]
        public string DestroyDebugReason { get; set; }
    }

    public class RisingDb_DestroyState
    {

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public class RisingDb_Age
    {

        [JsonProperty("Value")]
        public double Value { get; set; }
    }

    public class RisingDb_BuffCategory
    {

        [JsonProperty("Level")]
        public int Level { get; set; }

        [JsonProperty("Groups")]
        public string Groups { get; set; }

        [JsonProperty("KeepOldest")]
        public bool KeepOldest { get; set; }
    }

    public class RisingDb_LifeTime
    {

        [JsonProperty("Duration")]
        public double Duration { get; set; }

        [JsonProperty("EndAction")]
        public string EndAction { get; set; }
    }

    public class RisingDb_SharedGameplayConditionReference
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_GameplayConditionGroup
    {

        [JsonProperty("LogicGate")]
        public string LogicGate { get; set; }

        [JsonProperty("StartConditionIndex")]
        public int StartConditionIndex { get; set; }

        [JsonProperty("ConditionsLength")]
        public int ConditionsLength { get; set; }

        [JsonProperty("SubGroupStartIndex")]
        public int SubGroupStartIndex { get; set; }

        [JsonProperty("ConditionSubGroupsLength")]
        public int ConditionSubGroupsLength { get; set; }
    }

    public class RisingDb_EntityCategoryValue
    {

        [JsonProperty("MainCategory")]
        public string MainCategory { get; set; }

        [JsonProperty("UnitCategory")]
        public string UnitCategory { get; set; }

        [JsonProperty("StructureCategory")]
        public string StructureCategory { get; set; }

        [JsonProperty("MaterialCategory")]
        public string MaterialCategory { get; set; }

        [JsonProperty("ResourceLevel")]
        public int ResourceLevel { get; set; }
    }

    public class RisingDb_GameplayCondition
    {

        [JsonProperty("ConditionSource")]
        public string ConditionSource { get; set; }

        [JsonProperty("ConditionType")]
        public string ConditionType { get; set; }

        [JsonProperty("ConditionTarget")]
        public string ConditionTarget { get; set; }

        [JsonProperty("FloatValue")]
        public double FloatValue { get; set; }

        [JsonProperty("BoolValue")]
        public bool BoolValue { get; set; }

        [JsonProperty("IntValue")]
        public int IntValue { get; set; }

        [JsonProperty("PrefabValue")]
        public int PrefabValue { get; set; }

        [JsonProperty("EntityCategoryValue")]
        public RisingDb_EntityCategoryValue EntityCategoryValue { get; set; }

        [JsonProperty("WeapontTypeValue")]
        public string WeapontTypeValue { get; set; }
    }

    public class RisingDb_LocalizedStringBuilderParameter
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public class RisingDb_EventId
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_CreateGameplayEventsOnAbilityImpaired
    {

        [JsonProperty("PreviousIsImpaired")]
        public bool PreviousIsImpaired { get; set; }

        [JsonProperty("EventId")]
        public RisingDb_EventId EventId { get; set; }

        [JsonProperty("Source")]
        public string Source { get; set; }

        [JsonProperty("Target")]
        public string Target { get; set; }
    }

    public class RisingDb_EventId2
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_CreateGameplayEventsOnAbilityTrigger
    {

        [JsonProperty("EventId")]
        public RisingDb_EventId2 EventId { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Target")]
        public string Target { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }

        [JsonProperty("AbilityTypes")]
        public string AbilityTypes { get; set; }

        [JsonProperty("NumOfPrefabTargets")]
        public int NumOfPrefabTargets { get; set; }

        [JsonProperty("PrefabTargetStartIndex")]
        public int PrefabTargetStartIndex { get; set; }
    }

    public class RisingDb_EventId3
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_CreateGameplayEventsOnTick
    {

        [JsonProperty("EventId")]
        public RisingDb_EventId3 EventId { get; set; }

        [JsonProperty("Target")]
        public string Target { get; set; }

        [JsonProperty("TickInterval")]
        public double TickInterval { get; set; }

        [JsonProperty("TickTime")]
        public double TickTime { get; set; }

        [JsonProperty("MaxTicks")]
        public object MaxTicks { get; set; }

        [JsonProperty("CallScriptOnTick")]
        public bool CallScriptOnTick { get; set; }

        [JsonProperty("RandomTickOffset")]
        public double RandomTickOffset { get; set; }

        [JsonProperty("RandomTickInterval")]
        public double RandomTickInterval { get; set; }
    }

    public class RisingDb_DestroyOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }

        [JsonProperty("Who")]
        public string Who { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("DestroyReason")]
        public string DestroyReason { get; set; }
    }

    public class RisingDb_GameplayEventId
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_GameplayEventIdMapping
    {

        [JsonProperty("NextTriggerTime")]
        public double NextTriggerTime { get; set; }

        [JsonProperty("TriggerCooldown")]
        public double TriggerCooldown { get; set; }

        [JsonProperty("GameplayEventId")]
        public RisingDb_GameplayEventId GameplayEventId { get; set; }

        [JsonProperty("MaxTriggers")]
        public int MaxTriggers { get; set; }

        [JsonProperty("CurrentTriggers")]
        public int CurrentTriggers { get; set; }

        [JsonProperty("TriggerMultipleTimes")]
        public bool TriggerMultipleTimes { get; set; }
    }

    public class RisingDb_Entity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_TechData
    {

        [JsonProperty("Entity")]
        public RisingDb_Entity Entity { get; set; }

        [JsonProperty("Guid")]
        public int Guid { get; set; }

        [JsonProperty("TechCateogry")]
        public string TechCateogry { get; set; }

        [JsonProperty("CraftDuration")]
        public double CraftDuration { get; set; }

        [JsonProperty("HudSortingOrder")]
        public int HudSortingOrder { get; set; }

        [JsonProperty("NeverShowQuestionmarkResearch")]
        public bool NeverShowQuestionmarkResearch { get; set; }
    }

    public class RisingDb_TechUnlockAbilityBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }
    }

    public class RisingDb_TechUnlockRecipeBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }
    }

    public class RisingDb_TechUnlockBlueprintBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }
    }

    public class RisingDb_TechRequirementBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }
    }

    public class RisingDb_TechItemRequirementBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }

        [JsonProperty("Stacks")]
        public int Stacks { get; set; }
    }

    public class RisingDb_ProgressionBookShapeshiftElement
    {

        [JsonProperty("Shapeshift")]
        public int Shapeshift { get; set; }
    }

    public class RisingDb_Name
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_ManagedAbilityGroupData
    {

        [JsonProperty("Name")]
        public RisingDb_Name Name { get; set; }

        [JsonProperty("Icon")]
        public string Icon { get; set; }
    }

    public class RisingDb_Name2
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Key
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Description
    {

        [JsonProperty("Key")]
        public RisingDb_Key Key { get; set; }

        [JsonProperty("ParameterIndex")]
        public int ParameterIndex { get; set; }

        [JsonProperty("ParameterCount")]
        public int ParameterCount { get; set; }
    }

    public class RisingDb_AbilityTooltipData
    {

        [JsonProperty("Name")]
        public RisingDb_Name2 Name { get; set; }

        [JsonProperty("Description")]
        public RisingDb_Description Description { get; set; }

        [JsonProperty("Icon")]
        public string Icon { get; set; }

        [JsonProperty("TooltipType")]
        public string TooltipType { get; set; }

        [JsonProperty("SpawnPrefabOnCast")]
        public int SpawnPrefabOnCast { get; set; }
    }

    public class RisingDb__Entity2
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Character
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity2 _Entity { get; set; }
    }

    public class RisingDb_AbilityGroupState
    {

        [JsonProperty("Character")]
        public RisingDb_Character Character { get; set; }

        [JsonProperty("GroupId")]
        public int GroupId { get; set; }

        [JsonProperty("SlotIndex")]
        public int SlotIndex { get; set; }
    }

    public class RisingDb_VBloodAbilityData
    {

        [JsonProperty("AbilityType")]
        public string AbilityType { get; set; }

        [JsonProperty("AbilitySchool")]
        public string AbilitySchool { get; set; }
    }

    public class RisingDb__Entity3
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_StateEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity3 _Entity { get; set; }
    }

    public class RisingDb_AbilityStateBuffer
    {

        [JsonProperty("StateEntity")]
        public RisingDb_StateEntity StateEntity { get; set; }
    }

    public class RisingDb_FailKey
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_AbilityCastCondition
    {

        [JsonProperty("ConditionId")]
        public int ConditionId { get; set; }

        [JsonProperty("FailKey")]
        public RisingDb_FailKey FailKey { get; set; }
    }

    public class RisingDb_AbilityGroupStartAbilitiesBuffer
    {

        [JsonProperty("PrefabGUID")]
        public int PrefabGUID { get; set; }
    }

    public class RisingDb__Entity4
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_GroupEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity4 _Entity { get; set; }
    }

    public class RisingDb_AbilityState
    {

        [JsonProperty("AbilityTypeFlag")]
        public string AbilityTypeFlag { get; set; }

        [JsonProperty("AbilityId")]
        public int AbilityId { get; set; }

        [JsonProperty("GroupEntity")]
        public RisingDb_GroupEntity GroupEntity { get; set; }

        [JsonProperty("CastStartTime")]
        public double CastStartTime { get; set; }
    }

    public class RisingDb_AbilityCooldownState
    {

        [JsonProperty("CooldownEndTime")]
        public double CooldownEndTime { get; set; }

        [JsonProperty("CurrentCooldown")]
        public double CurrentCooldown { get; set; }
    }

    public class RisingDb_AbilityCooldownData
    {

        [JsonProperty("IgnoreCooldownModifier")]
        public bool IgnoreCooldownModifier { get; set; }

        [JsonProperty("MinCooldown")]
        public double MinCooldown { get; set; }

        [JsonProperty("MaxCooldown")]
        public double MaxCooldown { get; set; }
    }

    public class RisingDb_EnergyRequirement
    {

        [JsonProperty("Energy")]
        public double Energy { get; set; }

        [JsonProperty("DrainEnergyOnUse")]
        public bool DrainEnergyOnUse { get; set; }
    }

    public class RisingDb_GlobalCooldown
    {

        [JsonProperty("Value")]
        public double Value { get; set; }
    }

    public class RisingDb_AbilityCastTimeData
    {

        [JsonProperty("MaxCastTime")]
        public double MaxCastTime { get; set; }

        [JsonProperty("PostCastTime")]
        public double PostCastTime { get; set; }

        [JsonProperty("HideCastBar")]
        public bool HideCastBar { get; set; }

        [JsonProperty("TotalCastTime")]
        public double TotalCastTime { get; set; }
    }

    public class RisingDb_TargetEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_AbilitySpawnPrefabOnCast
    {

        [JsonProperty("SpawnPrefab")]
        public int SpawnPrefab { get; set; }

        [JsonProperty("Target")]
        public string Target { get; set; }

        [JsonProperty("TargetEntity")]
        public RisingDb_TargetEntity TargetEntity { get; set; }

        [JsonProperty("HoverDistance")]
        public double HoverDistance { get; set; }

        [JsonProperty("HoverConditionId")]
        public int HoverConditionId { get; set; }
    }

    public class RisingDb_SequencePrefab
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_AbilityCastSequenceData
    {

        [JsonProperty("SequencePrefab")]
        public RisingDb_SequencePrefab SequencePrefab { get; set; }
    }

    public class RisingDb_MagicSourceDurabilityRequirement
    {

        [JsonProperty("Durability")]
        public double Durability { get; set; }
    }

    public class RisingDb__Entity5
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb__BaseValue
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity5 _Entity { get; set; }
    }

    public class RisingDb__Entity6
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb__Value
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity6 _Entity { get; set; }
    }

    public class RisingDb__Entity7
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Value2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity7 _Entity { get; set; }
    }

    public class RisingDb__Entity8
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_prop_NetworkedEntity_0
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity8 _Entity { get; set; }
    }

    public class RisingDb__Entity9
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_prop_NetworkedEntity_1
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity9 _Entity { get; set; }
    }

    public class RisingDb_Value
    {

        [JsonProperty("_BaseValue")]
        public RisingDb__BaseValue _BaseValue { get; set; }

        [JsonProperty("_Value")]
        public RisingDb__Value _Value { get; set; }

        [JsonProperty("_Identifier")]
        public int _Identifier { get; set; }

        [JsonProperty("Value")]
        public RisingDb_Value2 Value { get; set; }

        [JsonProperty("prop_NetworkedEntity_0")]
        public RisingDb_prop_NetworkedEntity_0 prop_NetworkedEntity_0 { get; set; }

        [JsonProperty("prop_NetworkedEntity_1")]
        public RisingDb_prop_NetworkedEntity_1 prop_NetworkedEntity_1 { get; set; }
    }

    public class RisingDb_Team
    {

        [JsonProperty("Value")]
        public RisingDb_Value Value { get; set; }
    }

    public class RisingDb_StartPosition
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_EndPosition
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_TargetAoE
    {

        [JsonProperty("StartPosition")]
        public RisingDb_StartPosition StartPosition { get; set; }

        [JsonProperty("EndPosition")]
        public RisingDb_EndPosition EndPosition { get; set; }

        [JsonProperty("MaxRange")]
        public double MaxRange { get; set; }

        [JsonProperty("MinRange")]
        public double MinRange { get; set; }

        [JsonProperty("MaxTime")]
        public double MaxTime { get; set; }

        [JsonProperty("MinTime")]
        public double MinTime { get; set; }

        [JsonProperty("MaxRandomTimeAdded")]
        public double MaxRandomTimeAdded { get; set; }

        [JsonProperty("ThrowMaxHeightDiff")]
        public double ThrowMaxHeightDiff { get; set; }

        [JsonProperty("ThrowArcHeight")]
        public double ThrowArcHeight { get; set; }

        [JsonProperty("UseRandomOffset")]
        public bool UseRandomOffset { get; set; }

        [JsonProperty("RandomOffsetMin")]
        public double RandomOffsetMin { get; set; }

        [JsonProperty("RandomOffsetRadius")]
        public double RandomOffsetRadius { get; set; }

        [JsonProperty("MapCollisionRadius")]
        public double MapCollisionRadius { get; set; }

        [JsonProperty("FindValidPositionFromMax")]
        public bool FindValidPositionFromMax { get; set; }
    }

    public class RisingDb_ModifiableValueIds
    {

        [JsonProperty("IdCounter")]
        public int IdCounter { get; set; }
    }

    public class RisingDb_RagdollForceSource
    {

        [JsonProperty("RagdollSetting")]
        public int RagdollSetting { get; set; }

        [JsonProperty("ForceModifier")]
        public double ForceModifier { get; set; }
    }

    public class RisingDb_Sequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_ImpactSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Instance
    {

        [JsonProperty("Id")]
        public RisingDb_Id Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_TimeEvaluateCurve
    {

        [JsonProperty("CurveGuid")]
        public int CurveGuid { get; set; }

        [JsonProperty("FlipY")]
        public bool FlipY { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_TargetAOESequence
    {

        [JsonProperty("Sequence")]
        public RisingDb_Sequence Sequence { get; set; }

        [JsonProperty("ImpactSequence")]
        public RisingDb_ImpactSequence ImpactSequence { get; set; }

        [JsonProperty("Instance")]
        public RisingDb_Instance Instance { get; set; }

        [JsonProperty("TimeEvaluateCurve")]
        public RisingDb_TimeEvaluateCurve TimeEvaluateCurve { get; set; }
    }

    public class RisingDb_Offset
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_PrioritySettings
    {

        [JsonProperty("Near_Origin_Factor")]
        public double Near_Origin_Factor { get; set; }

        [JsonProperty("Near_Origin_Distance")]
        public double Near_Origin_Distance { get; set; }

        [JsonProperty("Target_Priority_Factor")]
        public double Target_Priority_Factor { get; set; }

        [JsonProperty("UseMeleeCone")]
        public bool UseMeleeCone { get; set; }

        [JsonProperty("Melee_Cone_Angle")]
        public double Melee_Cone_Angle { get; set; }
    }

    public class RisingDb_HitColliderCast
    {

        [JsonProperty("CollisionCheckType")]
        public string CollisionCheckType { get; set; }

        [JsonProperty("Offset")]
        public RisingDb_Offset Offset { get; set; }

        [JsonProperty("Cone_Radius")]
        public double Cone_Radius { get; set; }

        [JsonProperty("Cone_Angle")]
        public double Cone_Angle { get; set; }

        [JsonProperty("Box_Width")]
        public double Box_Width { get; set; }

        [JsonProperty("Box_Height")]
        public double Box_Height { get; set; }

        [JsonProperty("Box_Length")]
        public double Box_Length { get; set; }

        [JsonProperty("Circle_Radius")]
        public double Circle_Radius { get; set; }

        [JsonProperty("InnerCircle_Radius")]
        public double InnerCircle_Radius { get; set; }

        [JsonProperty("PrimaryFilterFlags")]
        public string PrimaryFilterFlags { get; set; }

        [JsonProperty("Shape")]
        public string Shape { get; set; }

        [JsonProperty("PrioritySettings")]
        public RisingDb_PrioritySettings PrioritySettings { get; set; }

        [JsonProperty("PrimaryTargets_Count")]
        public int PrimaryTargets_Count { get; set; }

        [JsonProperty("SecondaryTargets_Count")]
        public int SecondaryTargets_Count { get; set; }

        [JsonProperty("ContiniousCollision")]
        public bool ContiniousCollision { get; set; }

        [JsonProperty("IncludeDirectionalShield")]
        public bool IncludeDirectionalShield { get; set; }

        [JsonProperty("IncludeTerrain")]
        public bool IncludeTerrain { get; set; }

        [JsonProperty("CanHitThroughBlockSpellCollision")]
        public bool CanHitThroughBlockSpellCollision { get; set; }

        [JsonProperty("IgnoreImmaterial")]
        public bool IgnoreImmaterial { get; set; }

        [JsonProperty("TriggerType")]
        public string TriggerType { get; set; }

        [JsonProperty("Handled")]
        public bool Handled { get; set; }

        [JsonProperty("AfterDuration")]
        public double AfterDuration { get; set; }

        [JsonProperty("TerrainColliderModifier")]
        public double TerrainColliderModifier { get; set; }
    }

    public class RisingDb_EventId4
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_CreateGameplayEventsOnSpawn
    {

        [JsonProperty("EventId")]
        public RisingDb_EventId4 EventId { get; set; }

        [JsonProperty("Target")]
        public string Target { get; set; }
    }

    public class RisingDb_SequenceGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_PlaySequenceOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("SequenceGuid")]
        public RisingDb_SequenceGuid SequenceGuid { get; set; }

        [JsonProperty("SequencePositionTarget")]
        public string SequencePositionTarget { get; set; }

        [JsonProperty("SequenceRotationTarget")]
        public string SequenceRotationTarget { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }
    }

    public class RisingDb_RemoveBuffOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("BuffTarget")]
        public string BuffTarget { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }
    }

    public class RisingDb_RemoveBuffOnGameplayEventEntry
    {

        [JsonProperty("EventIndex")]
        public int EventIndex { get; set; }

        [JsonProperty("Buff")]
        public int Buff { get; set; }

        [JsonProperty("BuffCategoryFlag")]
        public string BuffCategoryFlag { get; set; }

        [JsonProperty("IncludeSelf")]
        public bool IncludeSelf { get; set; }
    }

    public class RisingDb_Name3
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Description2
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_ManagedCharacterHUD
    {

        [JsonProperty("PrefabName")]
        public string PrefabName { get; set; }

        [JsonProperty("Icon")]
        public string Icon { get; set; }

        [JsonProperty("Name")]
        public RisingDb_Name3 Name { get; set; }

        [JsonProperty("Description")]
        public RisingDb_Description2 Description { get; set; }
    }

    public class RisingDb_ClientCastGroupNetworkId
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Generation")]
        public int Generation { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb__Entity10
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_CastGroup
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity10 _Entity { get; set; }
    }

    public class RisingDb__Entity11
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_CastAbility
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity11 _Entity { get; set; }
    }

    public class RisingDb__Entity12
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_PreviousCastGroup
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity12 _Entity { get; set; }
    }

    public class RisingDb__Entity13
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_PreviousCastAbility
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity13 _Entity { get; set; }
    }

    public class RisingDb_SimulatedData
    {

        [JsonProperty("CanCast")]
        public bool CanCast { get; set; }

        [JsonProperty("LimitAbilityPriority")]
        public int LimitAbilityPriority { get; set; }

        [JsonProperty("GlobalCooldown")]
        public double GlobalCooldown { get; set; }

        [JsonProperty("CastStartTime")]
        public double CastStartTime { get; set; }

        [JsonProperty("CastTime")]
        public double CastTime { get; set; }

        [JsonProperty("PostCastTime")]
        public double PostCastTime { get; set; }

        [JsonProperty("InterruptTypes")]
        public string InterruptTypes { get; set; }

        [JsonProperty("CooldownOnInterrupt")]
        public double CooldownOnInterrupt { get; set; }

        [JsonProperty("ServerInterruptCounter")]
        public int ServerInterruptCounter { get; set; }

        [JsonProperty("CastStartedCounter")]
        public int CastStartedCounter { get; set; }

        [JsonProperty("CastCompletedCounter")]
        public int CastCompletedCounter { get; set; }

        [JsonProperty("ServerCastCounter")]
        public int ServerCastCounter { get; set; }

        [JsonProperty("ForceCastGroup")]
        public int ForceCastGroup { get; set; }

        [JsonProperty("CastGroup")]
        public RisingDb_CastGroup CastGroup { get; set; }

        [JsonProperty("CastAbility")]
        public RisingDb_CastAbility CastAbility { get; set; }

        [JsonProperty("PreviousCastGroup")]
        public RisingDb_PreviousCastGroup PreviousCastGroup { get; set; }

        [JsonProperty("PreviousCastAbility")]
        public RisingDb_PreviousCastAbility PreviousCastAbility { get; set; }

        [JsonProperty("CooldownModifier")]
        public double CooldownModifier { get; set; }

        [JsonProperty("TravelCooldownModifier")]
        public double TravelCooldownModifier { get; set; }

        [JsonProperty("WeaponCooldownModifier")]
        public double WeaponCooldownModifier { get; set; }

        [JsonProperty("SpellCooldownModifier")]
        public double SpellCooldownModifier { get; set; }

        [JsonProperty("TotalCastTime")]
        public double TotalCastTime { get; set; }
    }

    public class RisingDb_Id2
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_CastSequence
    {

        [JsonProperty("Id")]
        public RisingDb_Id2 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_AbilityBar_Client
    {

        [JsonProperty("ClientCastGroupNetworkId")]
        public RisingDb_ClientCastGroupNetworkId ClientCastGroupNetworkId { get; set; }

        [JsonProperty("SimulatedData")]
        public RisingDb_SimulatedData SimulatedData { get; set; }

        [JsonProperty("CastSequence")]
        public RisingDb_CastSequence CastSequence { get; set; }

        [JsonProperty("ClientCastStartedCounter")]
        public int ClientCastStartedCounter { get; set; }

        [JsonProperty("ClientInterruptCounter")]
        public int ClientInterruptCounter { get; set; }

        [JsonProperty("HandledServerInterruptCounter")]
        public int HandledServerInterruptCounter { get; set; }

        [JsonProperty("IsSimulating")]
        public bool IsSimulating { get; set; }
    }

    public class RisingDb__Entity14
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_CastGroup2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity14 _Entity { get; set; }
    }

    public class RisingDb__Entity15
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_CastAbility2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity15 _Entity { get; set; }
    }

    public class RisingDb__Entity16
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_PreviousCastGroup2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity16 _Entity { get; set; }
    }

    public class RisingDb__Entity17
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_PreviousCastAbility2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity17 _Entity { get; set; }
    }

    public class RisingDb_AbilityBar_Shared
    {

        [JsonProperty("CanCast")]
        public bool CanCast { get; set; }

        [JsonProperty("LimitAbilityPriority")]
        public int LimitAbilityPriority { get; set; }

        [JsonProperty("GlobalCooldown")]
        public double GlobalCooldown { get; set; }

        [JsonProperty("CastStartTime")]
        public double CastStartTime { get; set; }

        [JsonProperty("CastTime")]
        public double CastTime { get; set; }

        [JsonProperty("PostCastTime")]
        public double PostCastTime { get; set; }

        [JsonProperty("InterruptTypes")]
        public string InterruptTypes { get; set; }

        [JsonProperty("CooldownOnInterrupt")]
        public double CooldownOnInterrupt { get; set; }

        [JsonProperty("ServerInterruptCounter")]
        public int ServerInterruptCounter { get; set; }

        [JsonProperty("CastStartedCounter")]
        public int CastStartedCounter { get; set; }

        [JsonProperty("CastCompletedCounter")]
        public int CastCompletedCounter { get; set; }

        [JsonProperty("ServerCastCounter")]
        public int ServerCastCounter { get; set; }

        [JsonProperty("ForceCastGroup")]
        public int ForceCastGroup { get; set; }

        [JsonProperty("CastGroup")]
        public RisingDb_CastGroup2 CastGroup { get; set; }

        [JsonProperty("CastAbility")]
        public RisingDb_CastAbility2 CastAbility { get; set; }

        [JsonProperty("PreviousCastGroup")]
        public RisingDb_PreviousCastGroup2 PreviousCastGroup { get; set; }

        [JsonProperty("PreviousCastAbility")]
        public RisingDb_PreviousCastAbility2 PreviousCastAbility { get; set; }

        [JsonProperty("CooldownModifier")]
        public double CooldownModifier { get; set; }

        [JsonProperty("TravelCooldownModifier")]
        public double TravelCooldownModifier { get; set; }

        [JsonProperty("WeaponCooldownModifier")]
        public double WeaponCooldownModifier { get; set; }

        [JsonProperty("SpellCooldownModifier")]
        public double SpellCooldownModifier { get; set; }

        [JsonProperty("TotalCastTime")]
        public double TotalCastTime { get; set; }
    }

    public class RisingDb__Entity18
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_AggroTarget
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity18 _Entity { get; set; }
    }

    public class RisingDb__Entity19
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_AlertTarget
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity19 _Entity { get; set; }
    }

    public class RisingDb_PreCombatPosition
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_AggroConsumer
    {

        [JsonProperty("AggroTarget")]
        public RisingDb_AggroTarget AggroTarget { get; set; }

        [JsonProperty("AlertTarget")]
        public RisingDb_AlertTarget AlertTarget { get; set; }

        [JsonProperty("ProximityRadius")]
        public double ProximityRadius { get; set; }

        [JsonProperty("ProximityWeight")]
        public double ProximityWeight { get; set; }

        [JsonProperty("DamageWeight")]
        public double DamageWeight { get; set; }

        [JsonProperty("RemoveDelay")]
        public double RemoveDelay { get; set; }

        [JsonProperty("TargetSwitchThreshold")]
        public double TargetSwitchThreshold { get; set; }

        [JsonProperty("AlertDecayPerSecond")]
        public double AlertDecayPerSecond { get; set; }

        [JsonProperty("PreCombatPosition")]
        public RisingDb_PreCombatPosition PreCombatPosition { get; set; }

        [JsonProperty("MaxDistanceFromPreCombatPosition")]
        public double MaxDistanceFromPreCombatPosition { get; set; }

        [JsonProperty("AggroReason")]
        public string AggroReason { get; set; }

        [JsonProperty("DeaggroReason")]
        public string DeaggroReason { get; set; }

        [JsonProperty("Active")]
        public bool Active { get; set; }
    }

    public class RisingDb__BaseValue2
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb__Value2
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Value3
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_prop_Entity_0
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_prop_Entity_1
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Followed
    {

        [JsonProperty("_BaseValue")]
        public RisingDb__BaseValue2 _BaseValue { get; set; }

        [JsonProperty("_Value")]
        public RisingDb__Value2 _Value { get; set; }

        [JsonProperty("_Identifier")]
        public int _Identifier { get; set; }

        [JsonProperty("Value")]
        public RisingDb_Value3 Value { get; set; }

        [JsonProperty("prop_Entity_0")]
        public RisingDb_prop_Entity_0 prop_Entity_0 { get; set; }

        [JsonProperty("prop_Entity_1")]
        public RisingDb_prop_Entity_1 prop_Entity_1 { get; set; }
    }

    public class RisingDb_Offset2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_Follower
    {

        [JsonProperty("Followed")]
        public RisingDb_Followed Followed { get; set; }

        [JsonProperty("Offset")]
        public RisingDb_Offset2 Offset { get; set; }

        [JsonProperty("LastOffsetUpdateTime")]
        public double LastOffsetUpdateTime { get; set; }

        [JsonProperty("ModeModifiable")]
        public int ModeModifiable { get; set; }

        [JsonProperty("Stationary")]
        public bool Stationary { get; set; }

        [JsonProperty("InheritRotationWhenStationary")]
        public bool InheritRotationWhenStationary { get; set; }

        [JsonProperty("Mode")]
        public string Mode { get; set; }
    }

    public class RisingDb__BaseValue3
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb__Value3
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Value4
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_prop_Entity_02
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_prop_Entity_12
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_SettingsEntity
    {

        [JsonProperty("_BaseValue")]
        public RisingDb__BaseValue3 _BaseValue { get; set; }

        [JsonProperty("_Value")]
        public RisingDb__Value3 _Value { get; set; }

        [JsonProperty("_Identifier")]
        public int _Identifier { get; set; }

        [JsonProperty("Value")]
        public RisingDb_Value4 Value { get; set; }

        [JsonProperty("prop_Entity_0")]
        public RisingDb_prop_Entity_02 prop_Entity_0 { get; set; }

        [JsonProperty("prop_Entity_1")]
        public RisingDb_prop_Entity_12 prop_Entity_1 { get; set; }
    }

    public class RisingDb_BuffResistances
    {

        [JsonProperty("InitialSettingGuid")]
        public int InitialSettingGuid { get; set; }

        [JsonProperty("SettingsEntity")]
        public RisingDb_SettingsEntity SettingsEntity { get; set; }
    }

    public class RisingDb_Movement
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_AimPosition
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_ProjectileAimPosition
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_AimDirection
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_AimPositionPlane
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_HoveredEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_HoveredEntityNetworkId
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Generation")]
        public int Generation { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_MouseWorldPosition
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_MouseWorldPerspectivePositionPlane
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_MouseWorldPositionPlayerPlane
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_MouseWorldPositionPlayerPlaneTerrainProjection
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_AnalogValues
    {

        [JsonProperty("FixedElementField")]
        public double FixedElementField { get; set; }
    }

    public class RisingDb_State
    {

        [JsonProperty("ControllerType")]
        public string ControllerType { get; set; }

        [JsonProperty("InputsUp")]
        public string InputsUp { get; set; }

        [JsonProperty("InputsDown")]
        public string InputsDown { get; set; }

        [JsonProperty("InputsPressed")]
        public string InputsPressed { get; set; }

        [JsonProperty("InputsUpInThisContext")]
        public string InputsUpInThisContext { get; set; }

        [JsonProperty("InputsDownInThisContext")]
        public string InputsDownInThisContext { get; set; }

        [JsonProperty("InputsPressedInThisContext")]
        public string InputsPressedInThisContext { get; set; }

        [JsonProperty("MouseWorldPosition")]
        public RisingDb_MouseWorldPosition MouseWorldPosition { get; set; }

        [JsonProperty("MouseWorldPerspectivePositionPlane")]
        public RisingDb_MouseWorldPerspectivePositionPlane MouseWorldPerspectivePositionPlane { get; set; }

        [JsonProperty("MouseWorldPositionPlayerPlane")]
        public RisingDb_MouseWorldPositionPlayerPlane MouseWorldPositionPlayerPlane { get; set; }

        [JsonProperty("MouseWorldPositionPlayerPlaneTerrainProjection")]
        public RisingDb_MouseWorldPositionPlayerPlaneTerrainProjection MouseWorldPositionPlayerPlaneTerrainProjection { get; set; }

        [JsonProperty("AnalogValues")]
        public RisingDb_AnalogValues AnalogValues { get; set; }
    }

    public class RisingDb_EntityInput
    {

        [JsonProperty("Movement")]
        public RisingDb_Movement Movement { get; set; }

        [JsonProperty("AimPosition")]
        public RisingDb_AimPosition AimPosition { get; set; }

        [JsonProperty("ProjectileAimPosition")]
        public RisingDb_ProjectileAimPosition ProjectileAimPosition { get; set; }

        [JsonProperty("AimDirection")]
        public RisingDb_AimDirection AimDirection { get; set; }

        [JsonProperty("AimLength")]
        public double AimLength { get; set; }

        [JsonProperty("AimPositionPlane")]
        public RisingDb_AimPositionPlane AimPositionPlane { get; set; }

        [JsonProperty("HoveredEntity")]
        public RisingDb_HoveredEntity HoveredEntity { get; set; }

        [JsonProperty("HoveredEntityNetworkId")]
        public RisingDb_HoveredEntityNetworkId HoveredEntityNetworkId { get; set; }

        [JsonProperty("State")]
        public RisingDb_State State { get; set; }
    }

    public class RisingDb_Value5
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }

        [JsonProperty("z")]
        public int z { get; set; }

        [JsonProperty("w")]
        public int w { get; set; }
    }

    public class RisingDb_Guid
    {

        [JsonProperty("Value")]
        public RisingDb_Value5 Value { get; set; }
    }

    public class RisingDb_Footstep
    {

        [JsonProperty("Guid")]
        public RisingDb_Guid Guid { get; set; }

        [JsonProperty("PlayWhenNotMoving")]
        public bool PlayWhenNotMoving { get; set; }
    }

    public class RisingDb_FactionReference
    {

        [JsonProperty("FactionGuid")]
        public int FactionGuid { get; set; }
    }

    public class RisingDb_LocalizedName
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_LocalizedDesc
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_CharacterHUD
    {

        [JsonProperty("CacheFlag")]
        public string CacheFlag { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("PrefabType")]
        public string PrefabType { get; set; }

        [JsonProperty("BloodPrefabType")]
        public string BloodPrefabType { get; set; }

        [JsonProperty("Height")]
        public double Height { get; set; }

        [JsonProperty("LocalizedName")]
        public RisingDb_LocalizedName LocalizedName { get; set; }

        [JsonProperty("LocalizedDesc")]
        public RisingDb_LocalizedDesc LocalizedDesc { get; set; }

        [JsonProperty("TeamType")]
        public string TeamType { get; set; }

        [JsonProperty("EnemyColorTeamIndex")]
        public int EnemyColorTeamIndex { get; set; }

        [JsonProperty("HoveredTime")]
        public double HoveredTime { get; set; }

        [JsonProperty("HideHUD")]
        public bool HideHUD { get; set; }
    }

    public class RisingDb_Buffable
    {

        [JsonProperty("KnockbackResistanceIndex")]
        public int KnockbackResistanceIndex { get; set; }

        [JsonProperty("UniqueBuffCategories")]
        public string UniqueBuffCategories { get; set; }
    }

    public class RisingDb_Hideable
    {

        [JsonProperty("IsHidden")]
        public bool IsHidden { get; set; }
    }

    public class RisingDb_Stealthable
    {

        [JsonProperty("IsStealthed")]
        public bool IsStealthed { get; set; }

        [JsonProperty("StealthBushId")]
        public int StealthBushId { get; set; }

        [JsonProperty("ModelInvisible")]
        public bool ModelInvisible { get; set; }
    }

    public class RisingDb_Health
    {

        [JsonProperty("TimeOfDeath")]
        public double TimeOfDeath { get; set; }

        [JsonProperty("Value")]
        public double Value { get; set; }

        [JsonProperty("MaxRecoveryHealth")]
        public double MaxRecoveryHealth { get; set; }

        [JsonProperty("MaxHealth")]
        public double MaxHealth { get; set; }

        [JsonProperty("IsDead")]
        public bool IsDead { get; set; }
    }

    public class RisingDb_HealthConstants
    {

        [JsonProperty("LowHealthFactor")]
        public double LowHealthFactor { get; set; }

        [JsonProperty("DestroyOnDeath")]
        public bool DestroyOnDeath { get; set; }

        [JsonProperty("DestroyAfterDuration")]
        public double DestroyAfterDuration { get; set; }

        [JsonProperty("DisableDamageSCT")]
        public bool DisableDamageSCT { get; set; }
    }

    public class RisingDb_Value6
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_LastTranslation
    {

        [JsonProperty("Value")]
        public RisingDb_Value6 Value { get; set; }
    }

    public class RisingDb_Movement2
    {
    }

    public class RisingDb_CollisionRadius
    {

        [JsonProperty("Radius")]
        public double Radius { get; set; }
    }

    public class RisingDb_CollisionNormal
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_Result
    {

        [JsonProperty("Collision")]
        public bool Collision { get; set; }

        [JsonProperty("CollisionNormal")]
        public RisingDb_CollisionNormal CollisionNormal { get; set; }
    }

    public class RisingDb_MapCollision
    {

        [JsonProperty("Radius")]
        public double Radius { get; set; }

        [JsonProperty("CollidesAgainstMapFlags")]
        public string CollidesAgainstMapFlags { get; set; }

        [JsonProperty("IsActive")]
        public bool IsActive { get; set; }

        [JsonProperty("FlyOnly")]
        public bool FlyOnly { get; set; }

        [JsonProperty("Result")]
        public RisingDb_Result Result { get; set; }
    }

    public class RisingDb_Value7
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Velocity
    {

        [JsonProperty("Value")]
        public RisingDb_Value7 Value { get; set; }
    }

    public class RisingDb_Position
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_xyz
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_value8
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw zw { get; set; }
    }

    public class RisingDb_Rotation
    {

        [JsonProperty("value")]
        public RisingDb_value8 value { get; set; }
    }

    public class RisingDb_SpawnTransform
    {

        [JsonProperty("Position")]
        public RisingDb_Position Position { get; set; }

        [JsonProperty("Rotation")]
        public RisingDb_Rotation Rotation { get; set; }
    }

    public class RisingDb_Direction
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_AimDirection2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_ForcedDirection
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_TargetDirection
    {

        [JsonProperty("CanRotate")]
        public bool CanRotate { get; set; }

        [JsonProperty("CurrentCanRotate")]
        public bool CurrentCanRotate { get; set; }

        [JsonProperty("RotationSpeed")]
        public double RotationSpeed { get; set; }

        [JsonProperty("PlayerControlsRotation")]
        public bool PlayerControlsRotation { get; set; }

        [JsonProperty("DefaultRotationSpeed")]
        public double DefaultRotationSpeed { get; set; }

        [JsonProperty("Direction")]
        public RisingDb_Direction Direction { get; set; }

        [JsonProperty("AimDirection")]
        public RisingDb_AimDirection2 AimDirection { get; set; }

        [JsonProperty("ForcedDirection")]
        public RisingDb_ForcedDirection ForcedDirection { get; set; }

        [JsonProperty("RotateTowardsMouse")]
        public bool RotateTowardsMouse { get; set; }

        [JsonProperty("ForceRotateTowardsMovement")]
        public bool ForceRotateTowardsMovement { get; set; }
    }

    public class RisingDb_Min
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }
    }

    public class RisingDb_Max
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }
    }

    public class RisingDb_Value9
    {

        [JsonProperty("Min")]
        public RisingDb_Min Min { get; set; }

        [JsonProperty("Max")]
        public RisingDb_Max Max { get; set; }
    }

    public class RisingDb_TileBounds
    {

        [JsonProperty("Value")]
        public RisingDb_Value9 Value { get; set; }
    }

    public class RisingDb_TileData
    {
    }

    public class RisingDb_EntityCategory
    {

        [JsonProperty("MainCategory")]
        public string MainCategory { get; set; }

        [JsonProperty("UnitCategory")]
        public string UnitCategory { get; set; }

        [JsonProperty("StructureCategory")]
        public string StructureCategory { get; set; }

        [JsonProperty("MaterialCategory")]
        public string MaterialCategory { get; set; }

        [JsonProperty("ResourceLevel")]
        public int ResourceLevel { get; set; }
    }

    public class RisingDb_Immaterial
    {

        [JsonProperty("Value")]
        public bool Value { get; set; }
    }

    public class RisingDb_UnitLevel
    {

        [JsonProperty("Level")]
        public int Level { get; set; }
    }

    public class RisingDb_Vision
    {

        [JsonProperty("Range")]
        public double Range { get; set; }

        [JsonProperty("FlyingHeightVision")]
        public bool FlyingHeightVision { get; set; }
    }

    public class RisingDb_AimPosition2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_AimPositionPlane2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_ProjectileAimPosition2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_EntityAimData
    {

        [JsonProperty("AimPosition")]
        public RisingDb_AimPosition2 AimPosition { get; set; }

        [JsonProperty("AimPositionPlane")]
        public RisingDb_AimPositionPlane2 AimPositionPlane { get; set; }

        [JsonProperty("ProjectileAimPosition")]
        public RisingDb_ProjectileAimPosition2 ProjectileAimPosition { get; set; }
    }

    public class RisingDb_ResistanceData
    {

        [JsonProperty("SunResistance_IncreasedSunPiercingDuration")]
        public double SunResistance_IncreasedSunPiercingDuration { get; set; }

        [JsonProperty("GarlicResistance_DamageReductionPerRating")]
        public double GarlicResistance_DamageReductionPerRating { get; set; }

        [JsonProperty("GarlicResistance_IncreasedExposureFactorPerRating")]
        public double GarlicResistance_IncreasedExposureFactorPerRating { get; set; }

        [JsonProperty("GarlicResistance_ReduceMaxStacksPerRating")]
        public double GarlicResistance_ReduceMaxStacksPerRating { get; set; }

        [JsonProperty("FireResistance_DamageReductionPerRating")]
        public double FireResistance_DamageReductionPerRating { get; set; }

        [JsonProperty("FireResistance_RedcuedIgiteChancePerRating")]
        public double FireResistance_RedcuedIgiteChancePerRating { get; set; }

        [JsonProperty("SilverResistance_DamageReductionPerRating")]
        public double SilverResistance_DamageReductionPerRating { get; set; }

        [JsonProperty("SilverResistance_CarryValueAbsorbedPerRating")]
        public double SilverResistance_CarryValueAbsorbedPerRating { get; set; }

        [JsonProperty("HolyResistance_DamageReductionPerRating")]
        public double HolyResistance_DamageReductionPerRating { get; set; }

        [JsonProperty("HolyResistance_DamageAbsorbPerRating")]
        public double HolyResistance_DamageAbsorbPerRating { get; set; }
    }

    public class RisingDb_UnitStats
    {

        [JsonProperty("PhysicalCriticalStrikeChance")]
        public double PhysicalCriticalStrikeChance { get; set; }

        [JsonProperty("PhysicalCriticalStrikeDamage")]
        public double PhysicalCriticalStrikeDamage { get; set; }

        [JsonProperty("SpellCriticalStrikeChance")]
        public double SpellCriticalStrikeChance { get; set; }

        [JsonProperty("SpellCriticalStrikeDamage")]
        public double SpellCriticalStrikeDamage { get; set; }

        [JsonProperty("PhysicalPower")]
        public double PhysicalPower { get; set; }

        [JsonProperty("SpellPower")]
        public double SpellPower { get; set; }

        [JsonProperty("ResourcePower")]
        public double ResourcePower { get; set; }

        [JsonProperty("SiegePower")]
        public double SiegePower { get; set; }

        [JsonProperty("ResourceYieldModifier")]
        public double ResourceYieldModifier { get; set; }

        [JsonProperty("ReducedResourceDurabilityLoss")]
        public double ReducedResourceDurabilityLoss { get; set; }

        [JsonProperty("PhysicalResistance")]
        public double PhysicalResistance { get; set; }

        [JsonProperty("SpellResistance")]
        public double SpellResistance { get; set; }

        [JsonProperty("SunResistance")]
        public int SunResistance { get; set; }

        [JsonProperty("FireResistance")]
        public int FireResistance { get; set; }

        [JsonProperty("HolyResistance")]
        public int HolyResistance { get; set; }

        [JsonProperty("SilverResistance")]
        public int SilverResistance { get; set; }

        [JsonProperty("GarlicResistance")]
        public int GarlicResistance { get; set; }

        [JsonProperty("PassiveHealthRegen")]
        public double PassiveHealthRegen { get; set; }

        [JsonProperty("AttackSpeed")]
        public double AttackSpeed { get; set; }

        [JsonProperty("PrimaryAttackSpeed")]
        public double PrimaryAttackSpeed { get; set; }

        [JsonProperty("DamageVsUndeads")]
        public double DamageVsUndeads { get; set; }

        [JsonProperty("DamageVsHumans")]
        public double DamageVsHumans { get; set; }

        [JsonProperty("DamageVsDemons")]
        public double DamageVsDemons { get; set; }

        [JsonProperty("DamageVsMechanical")]
        public double DamageVsMechanical { get; set; }

        [JsonProperty("DamageVsBeasts")]
        public double DamageVsBeasts { get; set; }

        [JsonProperty("DamageVsCastleObjects")]
        public double DamageVsCastleObjects { get; set; }

        [JsonProperty("DamageVsPlayerVampires")]
        public double DamageVsPlayerVampires { get; set; }

        [JsonProperty("ResistVsUndeads")]
        public double ResistVsUndeads { get; set; }

        [JsonProperty("ResistVsHumans")]
        public double ResistVsHumans { get; set; }

        [JsonProperty("ResistVsDemons")]
        public double ResistVsDemons { get; set; }

        [JsonProperty("ResistVsMechanical")]
        public double ResistVsMechanical { get; set; }

        [JsonProperty("ResistVsBeasts")]
        public double ResistVsBeasts { get; set; }

        [JsonProperty("ResistVsPlayerVampires")]
        public double ResistVsPlayerVampires { get; set; }

        [JsonProperty("DamageVsWood")]
        public double DamageVsWood { get; set; }

        [JsonProperty("DamageVsMineral")]
        public double DamageVsMineral { get; set; }

        [JsonProperty("DamageVsVegetation")]
        public double DamageVsVegetation { get; set; }

        [JsonProperty("DamageVsLightArmor")]
        public double DamageVsLightArmor { get; set; }

        [JsonProperty("DamageVsHeavyArmor")]
        public double DamageVsHeavyArmor { get; set; }

        [JsonProperty("DamageVsMagic")]
        public double DamageVsMagic { get; set; }

        [JsonProperty("ImmuneToHazards")]
        public bool ImmuneToHazards { get; set; }

        [JsonProperty("PvPProtected")]
        public bool PvPProtected { get; set; }

        [JsonProperty("HealthRecovery")]
        public double HealthRecovery { get; set; }
    }

    public class RisingDb_GenericCombatMovementData
    {

        [JsonProperty("MinDistance")]
        public double MinDistance { get; set; }

        [JsonProperty("GoalDistanceInner")]
        public double GoalDistanceInner { get; set; }

        [JsonProperty("GoalDistanceOuter")]
        public double GoalDistanceOuter { get; set; }

        [JsonProperty("MaxDistance")]
        public double MaxDistance { get; set; }

        [JsonProperty("MovePattern")]
        public int MovePattern { get; set; }
    }

    public class RisingDb_MiscAiGameplayData
    {

        [JsonProperty("StationaryWhenIdle")]
        public bool StationaryWhenIdle { get; set; }

        [JsonProperty("AlertAlliesOnDeath")]
        public bool AlertAlliesOnDeath { get; set; }

        [JsonProperty("IgnoresPathfindingLineOfSight")]
        public bool IgnoresPathfindingLineOfSight { get; set; }

        [JsonProperty("IsFleeing")]
        public bool IsFleeing { get; set; }
    }

    public class RisingDb_Offset3
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_ImpactMaterial
    {

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Offset")]
        public RisingDb_Offset3 Offset { get; set; }

        [JsonProperty("PlayOnSelf")]
        public bool PlayOnSelf { get; set; }
    }

    public class RisingDb_HybridModelSeed
    {

        [JsonProperty("Seed")]
        public int Seed { get; set; }

        [JsonProperty("HasSetSeed")]
        public bool HasSetSeed { get; set; }
    }

    public class RisingDb_TileModel
    {

        [JsonProperty("DisabledTileTypes")]
        public string DisabledTileTypes { get; set; }
    }

    public class RisingDb_ScreenPosition
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_CheckOnScreen
    {

        [JsonProperty("PixelOffset")]
        public double PixelOffset { get; set; }

        [JsonProperty("IgnoreLineOfSight")]
        public bool IgnoreLineOfSight { get; set; }

        [JsonProperty("IsOnScreen")]
        public bool IsOnScreen { get; set; }

        [JsonProperty("HasLineOfSight")]
        public bool HasLineOfSight { get; set; }

        [JsonProperty("ScreenPosition")]
        public RisingDb_ScreenPosition ScreenPosition { get; set; }
    }

    public class RisingDb_PlacementDestroyData
    {

        [JsonProperty("DestroyReason")]
        public string DestroyReason { get; set; }
    }

    public class RisingDb_CurrentTargetSequenceGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Interactable
    {

        [JsonProperty("IgnoreLineOfSight")]
        public bool IgnoreLineOfSight { get; set; }

        [JsonProperty("IgnoreBlockInteract")]
        public bool IgnoreBlockInteract { get; set; }

        [JsonProperty("UseInteractAbilityName")]
        public bool UseInteractAbilityName { get; set; }

        [JsonProperty("CurrentTargetSequenceGuid")]
        public RisingDb_CurrentTargetSequenceGuid CurrentTargetSequenceGuid { get; set; }
    }

    public class RisingDb_InteractedUpon
    {

        [JsonProperty("Interacting")]
        public bool Interacting { get; set; }

        [JsonProperty("BlockBuildingMovement")]
        public bool BlockBuildingMovement { get; set; }

        [JsonProperty("BlockBuildingDisassemble")]
        public bool BlockBuildingDisassemble { get; set; }
    }

    public class RisingDb_AgainstUnits
    {

        [JsonProperty("HardnessThreshold")]
        public double HardnessThreshold { get; set; }

        [JsonProperty("PushStrengthMin")]
        public double PushStrengthMin { get; set; }

        [JsonProperty("PushStrengthMax")]
        public double PushStrengthMax { get; set; }

        [JsonProperty("RadiusOverride")]
        public double RadiusOverride { get; set; }

        [JsonProperty("RadiusVariation")]
        public double RadiusVariation { get; set; }
    }

    public class RisingDb_AgainstPlayers
    {

        [JsonProperty("HardnessThreshold")]
        public double HardnessThreshold { get; set; }

        [JsonProperty("PushStrengthMin")]
        public double PushStrengthMin { get; set; }

        [JsonProperty("PushStrengthMax")]
        public double PushStrengthMax { get; set; }

        [JsonProperty("RadiusOverride")]
        public double RadiusOverride { get; set; }

        [JsonProperty("RadiusVariation")]
        public double RadiusVariation { get; set; }
    }

    public class RisingDb_NetworkDirection
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_DynamicCollision
    {

        [JsonProperty("AgainstUnits")]
        public RisingDb_AgainstUnits AgainstUnits { get; set; }

        [JsonProperty("AgainstPlayers")]
        public RisingDb_AgainstPlayers AgainstPlayers { get; set; }

        [JsonProperty("Immobile")]
        public bool Immobile { get; set; }

        [JsonProperty("NetworkMultiplier")]
        public double NetworkMultiplier { get; set; }

        [JsonProperty("NetworkDirection")]
        public RisingDb_NetworkDirection NetworkDirection { get; set; }

        [JsonProperty("IsActive")]
        public bool IsActive { get; set; }
    }

    public class RisingDb_LastPosition
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Height
    {

        [JsonProperty("DisableCorrection")]
        public bool DisableCorrection { get; set; }

        [JsonProperty("Value")]
        public double Value { get; set; }

        [JsonProperty("LastPosition")]
        public RisingDb_LastPosition LastPosition { get; set; }
    }

    public class RisingDb_IsSpellControlled
    {

        [JsonProperty("Value")]
        public bool Value { get; set; }
    }

    public class RisingDb_HealthBarHUD
    {

        [JsonProperty("HealthAnimationDelay")]
        public double HealthAnimationDelay { get; set; }

        [JsonProperty("HealthAnimationTime")]
        public double HealthAnimationTime { get; set; }

        [JsonProperty("StartHealth")]
        public double StartHealth { get; set; }

        [JsonProperty("CalculatedHealth")]
        public double CalculatedHealth { get; set; }

        [JsonProperty("GoalHealth")]
        public double GoalHealth { get; set; }

        [JsonProperty("LastHealthChangeTime")]
        public double LastHealthChangeTime { get; set; }

        [JsonProperty("Absorb")]
        public double Absorb { get; set; }

        [JsonProperty("TeamType")]
        public string TeamType { get; set; }
    }

    public class RisingDb__Entity20
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_GroupSlotEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity20 _Entity { get; set; }
    }

    public class RisingDb_AbilityGroupSlotBuffer
    {

        [JsonProperty("BaseAbilityGroupOnSlot")]
        public int BaseAbilityGroupOnSlot { get; set; }

        [JsonProperty("ShowOnBar")]
        public bool ShowOnBar { get; set; }

        [JsonProperty("GroupSlotEntity")]
        public RisingDb_GroupSlotEntity GroupSlotEntity { get; set; }

        [JsonProperty("IsSlotEntityInitialized")]
        public bool IsSlotEntityInitialized { get; set; }
    }

    public class RisingDb_Value10
    {

        [JsonProperty("AnimationName")]
        public string AnimationName { get; set; }

        [JsonProperty("StartTime")]
        public double StartTime { get; set; }

        [JsonProperty("BlendInTime")]
        public double BlendInTime { get; set; }

        [JsonProperty("BlendOutTime")]
        public double BlendOutTime { get; set; }

        [JsonProperty("BlendOutTimeIfRunning")]
        public double BlendOutTimeIfRunning { get; set; }

        [JsonProperty("Duration")]
        public double Duration { get; set; }

        [JsonProperty("AnimationType")]
        public string AnimationType { get; set; }

        [JsonProperty("AnimationScaleMode")]
        public string AnimationScaleMode { get; set; }

        [JsonProperty("PlaybackSpeed")]
        public double PlaybackSpeed { get; set; }

        [JsonProperty("Importance")]
        public int Importance { get; set; }

        [JsonProperty("ExitIfRunning")]
        public bool ExitIfRunning { get; set; }

        [JsonProperty("CanPlayMultipleTimes")]
        public bool CanPlayMultipleTimes { get; set; }

        [JsonProperty("UseChestAimIk")]
        public bool UseChestAimIk { get; set; }
    }

    public class RisingDb_AnimationStateBuffer
    {

        [JsonProperty("Value")]
        public RisingDb_Value10 Value { get; set; }
    }

    public class RisingDb_InteractAbilityBuffer
    {

        [JsonProperty("Ability")]
        public int Ability { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }

        [JsonProperty("Importance")]
        public int Importance { get; set; }

        [JsonProperty("HideInteractHUDWhileCasting")]
        public bool HideInteractHUDWhileCasting { get; set; }
    }

    public class RisingDb_DropTableBuffer
    {

        [JsonProperty("DropTableGuid")]
        public int DropTableGuid { get; set; }

        [JsonProperty("DropTrigger")]
        public string DropTrigger { get; set; }

        [JsonProperty("RelicType")]
        public string RelicType { get; set; }
    }

    public class RisingDb_Text
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Script_SCTChatOnAggro_Buffer
    {

        [JsonProperty("Text")]
        public RisingDb_Text Text { get; set; }

        [JsonProperty("Weight")]
        public int Weight { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }
    }

    public class RisingDb_Name4
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Key2
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Description3
    {

        [JsonProperty("Key")]
        public RisingDb_Key2 Key { get; set; }

        [JsonProperty("ParameterIndex")]
        public int ParameterIndex { get; set; }

        [JsonProperty("ParameterCount")]
        public int ParameterCount { get; set; }
    }

    public class RisingDb_ManagedBlueprintData
    {

        [JsonProperty("Name")]
        public RisingDb_Name4 Name { get; set; }

        [JsonProperty("Description")]
        public RisingDb_Description3 Description { get; set; }

        [JsonProperty("Icon")]
        public string Icon { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("LimitedType")]
        public string LimitedType { get; set; }
    }

    public class RisingDb_Entity2
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_PlaceSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_InvalidPlaceSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_EditSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_InvalidEditSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_BuildingSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_DismantledSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_DestroyedSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_RepairedSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_BlueprintData
    {

        [JsonProperty("Entity")]
        public RisingDb_Entity2 Entity { get; set; }

        [JsonProperty("Guid")]
        public int Guid { get; set; }

        [JsonProperty("PlaceSequence")]
        public RisingDb_PlaceSequence PlaceSequence { get; set; }

        [JsonProperty("InvalidPlaceSequence")]
        public RisingDb_InvalidPlaceSequence InvalidPlaceSequence { get; set; }

        [JsonProperty("EditSequence")]
        public RisingDb_EditSequence EditSequence { get; set; }

        [JsonProperty("InvalidEditSequence")]
        public RisingDb_InvalidEditSequence InvalidEditSequence { get; set; }

        [JsonProperty("BuildingSequence")]
        public RisingDb_BuildingSequence BuildingSequence { get; set; }

        [JsonProperty("DismantledSequence")]
        public RisingDb_DismantledSequence DismantledSequence { get; set; }

        [JsonProperty("DestroyedSequence")]
        public RisingDb_DestroyedSequence DestroyedSequence { get; set; }

        [JsonProperty("RepairedSequence")]
        public RisingDb_RepairedSequence RepairedSequence { get; set; }

        [JsonProperty("DismantleFraction")]
        public double DismantleFraction { get; set; }

        [JsonProperty("FullDismantleTime")]
        public double FullDismantleTime { get; set; }

        [JsonProperty("IsStartBlueprint")]
        public bool IsStartBlueprint { get; set; }

        [JsonProperty("IsInventoryItemBuilding")]
        public bool IsInventoryItemBuilding { get; set; }

        [JsonProperty("ExitBuildModeWhenBuilt")]
        public bool ExitBuildModeWhenBuilt { get; set; }

        [JsonProperty("RequiresLineOfSight")]
        public bool RequiresLineOfSight { get; set; }

        [JsonProperty("RequiresSuccessfullPathfinding")]
        public bool RequiresSuccessfullPathfinding { get; set; }
    }

    public class RisingDb__Entity21
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_CurrentEditor
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity21 _Entity { get; set; }
    }

    public class RisingDb_EditableTileModel
    {

        [JsonProperty("CurrentEditor")]
        public RisingDb_CurrentEditor CurrentEditor { get; set; }

        [JsonProperty("IsEdited")]
        public bool IsEdited { get; set; }

        [JsonProperty("IsDismantling")]
        public bool IsDismantling { get; set; }

        [JsonProperty("IsRepairing")]
        public bool IsRepairing { get; set; }

        [JsonProperty("DismantleAbility")]
        public int DismantleAbility { get; set; }

        [JsonProperty("PlaceAbility")]
        public int PlaceAbility { get; set; }

        [JsonProperty("RepairAbility")]
        public int RepairAbility { get; set; }

        [JsonProperty("CanRotateDuringBuild")]
        public bool CanRotateDuringBuild { get; set; }

        [JsonProperty("CanMoveAfterBuild")]
        public bool CanMoveAfterBuild { get; set; }

        [JsonProperty("CanRotateAfterBuild")]
        public bool CanRotateAfterBuild { get; set; }

        [JsonProperty("CanDismantle")]
        public bool CanDismantle { get; set; }

        [JsonProperty("CanRepair")]
        public bool CanRepair { get; set; }
    }

    public class RisingDb_EffectTarget
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ActiveEffectTarget
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_EditedSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_HoveredCanBeEditedSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_HoveredOnlyDismantleSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_HoveredBlockedSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_DismantlingSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_RepairingSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id3
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_EditedSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id3 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Id4
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_HoveredSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id4 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Id5
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_DismantlingSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id5 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Id6
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_RepairingSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id6 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_EditableTileModel_Client
    {

        [JsonProperty("CurrentEditOptions")]
        public string CurrentEditOptions { get; set; }

        [JsonProperty("IsHovered")]
        public bool IsHovered { get; set; }

        [JsonProperty("EffectTarget")]
        public RisingDb_EffectTarget EffectTarget { get; set; }

        [JsonProperty("ActiveEffectTarget")]
        public RisingDb_ActiveEffectTarget ActiveEffectTarget { get; set; }

        [JsonProperty("EditedSequence")]
        public RisingDb_EditedSequence EditedSequence { get; set; }

        [JsonProperty("HoveredCanBeEditedSequence")]
        public RisingDb_HoveredCanBeEditedSequence HoveredCanBeEditedSequence { get; set; }

        [JsonProperty("HoveredOnlyDismantleSequence")]
        public RisingDb_HoveredOnlyDismantleSequence HoveredOnlyDismantleSequence { get; set; }

        [JsonProperty("HoveredBlockedSequence")]
        public RisingDb_HoveredBlockedSequence HoveredBlockedSequence { get; set; }

        [JsonProperty("DismantlingSequence")]
        public RisingDb_DismantlingSequence DismantlingSequence { get; set; }

        [JsonProperty("RepairingSequence")]
        public RisingDb_RepairingSequence RepairingSequence { get; set; }

        [JsonProperty("EditedSequenceState")]
        public RisingDb_EditedSequenceState EditedSequenceState { get; set; }

        [JsonProperty("HoveredSequenceState")]
        public RisingDb_HoveredSequenceState HoveredSequenceState { get; set; }

        [JsonProperty("DismantlingSequenceState")]
        public RisingDb_DismantlingSequenceState DismantlingSequenceState { get; set; }

        [JsonProperty("RepairingSequenceState")]
        public RisingDb_RepairingSequenceState RepairingSequenceState { get; set; }
    }

    public class RisingDb__Entity22
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_CastleHeartEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity22 _Entity { get; set; }
    }

    public class RisingDb_CastleHeartConnection
    {

        [JsonProperty("CastleHeartEntity")]
        public RisingDb_CastleHeartEntity CastleHeartEntity { get; set; }
    }

    public class RisingDb_Id7
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_DismantleSequenceInstance
    {

        [JsonProperty("Id")]
        public RisingDb_Id7 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_DismantleDestroyData
    {

        [JsonProperty("DismantleDestroyTime")]
        public double DismantleDestroyTime { get; set; }

        [JsonProperty("SkipDismantleTimeIfReplaced")]
        public bool SkipDismantleTimeIfReplaced { get; set; }

        [JsonProperty("WasDismantled")]
        public bool WasDismantled { get; set; }

        [JsonProperty("DismantleSequenceInstance")]
        public RisingDb_DismantleSequenceInstance DismantleSequenceInstance { get; set; }
    }

    public class RisingDb_ProgressionUserContentDependency
    {

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public class RisingDb_CreatedTime
    {

        [JsonProperty("CreateTime")]
        public double CreateTime { get; set; }
    }

    public class RisingDb_Immortal
    {

        [JsonProperty("IsImmortal")]
        public bool IsImmortal { get; set; }
    }

    public class RisingDb_Value11
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }

        [JsonProperty("z")]
        public int z { get; set; }

        [JsonProperty("w")]
        public int w { get; set; }
    }

    public class RisingDb_OpenSound
    {

        [JsonProperty("Value")]
        public RisingDb_Value11 Value { get; set; }
    }

    public class RisingDb_Value12
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }

        [JsonProperty("z")]
        public int z { get; set; }

        [JsonProperty("w")]
        public int w { get; set; }
    }

    public class RisingDb_CloseSound
    {

        [JsonProperty("Value")]
        public RisingDb_Value12 Value { get; set; }
    }

    public class RisingDb_StationMenuSounds
    {

        [JsonProperty("OpenSound")]
        public RisingDb_OpenSound OpenSound { get; set; }

        [JsonProperty("CloseSound")]
        public RisingDb_CloseSound CloseSound { get; set; }
    }

    public class RisingDb_Entity3
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_StaticHierarchyBuffer
    {

        [JsonProperty("Entity")]
        public RisingDb_Entity3 Entity { get; set; }

        [JsonProperty("BlobIndex")]
        public int BlobIndex { get; set; }
    }

    public class RisingDb_BlueprintRequirementBuffer
    {

        [JsonProperty("PrefabGUID")]
        public int PrefabGUID { get; set; }

        [JsonProperty("Stacks")]
        public int Stacks { get; set; }
    }

    public class RisingDb__Entity23
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ExternalInventoryEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity23 _Entity { get; set; }
    }

    public class RisingDb_InventoryOwner
    {

        [JsonProperty("Slots")]
        public int Slots { get; set; }

        [JsonProperty("ExternalInventoryEntityPrefabGuid")]
        public int ExternalInventoryEntityPrefabGuid { get; set; }

        [JsonProperty("ExternalInventoryEntity")]
        public RisingDb_ExternalInventoryEntity ExternalInventoryEntity { get; set; }
    }

    public class RisingDb__Entity24
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_RoomEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity24 _Entity { get; set; }
    }

    public class RisingDb_CastleRoomConnection
    {

        [JsonProperty("RoomEntity")]
        public RisingDb_RoomEntity RoomEntity { get; set; }
    }

    public class RisingDb_StationServants
    {

        [JsonProperty("Servants")]
        public string Servants { get; set; }
    }

    public class RisingDb_CastleWorkstation
    {

        [JsonProperty("MatchingFloorType")]
        public string MatchingFloorType { get; set; }

        [JsonProperty("BonusServantType")]
        public string BonusServantType { get; set; }

        [JsonProperty("WorkstationLevel")]
        public string WorkstationLevel { get; set; }
    }

    public class RisingDb_CastleBuildingAttachSettings
    {

        [JsonProperty("MoveWithParentWhenAttached")]
        public bool MoveWithParentWhenAttached { get; set; }

        [JsonProperty("DestroyWithParentWhenAttached")]
        public bool DestroyWithParentWhenAttached { get; set; }

        [JsonProperty("LinkDestroyToParentWhenAttached")]
        public bool LinkDestroyToParentWhenAttached { get; set; }

        [JsonProperty("RestrictMoveWhenAttached")]
        public bool RestrictMoveWhenAttached { get; set; }

        [JsonProperty("RestrictDismantleWhenAttached")]
        public bool RestrictDismantleWhenAttached { get; set; }

        [JsonProperty("MoveWithParentAlsoMovesOtherParents")]
        public bool MoveWithParentAlsoMovesOtherParents { get; set; }
    }

    public class RisingDb__Entity25
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ItemEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity25 _Entity { get; set; }
    }

    public class RisingDb_InventoryBuffer
    {

        [JsonProperty("ItemEntity")]
        public RisingDb_ItemEntity ItemEntity { get; set; }

        [JsonProperty("ItemType")]
        public int ItemType { get; set; }

        [JsonProperty("Stacks")]
        public int Stacks { get; set; }

        [JsonProperty("MaxStacksOverride")]
        public int MaxStacksOverride { get; set; }
    }

    public class RisingDb_StationBonusBuffer
    {

        [JsonProperty("StationBonusGuid")]
        public int StationBonusGuid { get; set; }
    }

    public class RisingDb_WorkstationRecipesBuffer
    {

        [JsonProperty("RecipeGuid")]
        public int RecipeGuid { get; set; }
    }

    public class RisingDb_ActivatedSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id8
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ActivatedSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id8 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_SpiderCocoon_DataShared
    {

        [JsonProperty("SpawnChance")]
        public double SpawnChance { get; set; }

        [JsonProperty("IsProximityActivated")]
        public bool IsProximityActivated { get; set; }

        [JsonProperty("IsProximityActivatedChance")]
        public double IsProximityActivatedChance { get; set; }

        [JsonProperty("ProximityRadius")]
        public double ProximityRadius { get; set; }

        [JsonProperty("ProximityActivationTime")]
        public double ProximityActivationTime { get; set; }

        [JsonProperty("LifetimeBuff")]
        public int LifetimeBuff { get; set; }

        [JsonProperty("ActivatedSequence")]
        public RisingDb_ActivatedSequence ActivatedSequence { get; set; }

        [JsonProperty("ActivatedSequenceState")]
        public RisingDb_ActivatedSequenceState ActivatedSequenceState { get; set; }

        [JsonProperty("Activated")]
        public bool Activated { get; set; }
    }

    public class RisingDb_SequenceGuid2
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_PlaySequenceOnDestroy
    {

        [JsonProperty("SequenceGuid")]
        public RisingDb_SequenceGuid2 SequenceGuid { get; set; }
    }

    public class RisingDb_ProgressionDependencyElement
    {

        [JsonProperty("PrefabGuid")]
        public int PrefabGuid { get; set; }
    }

    public class RisingDb_Value13
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_LocalTranslation
    {

        [JsonProperty("Value")]
        public RisingDb_Value13 Value { get; set; }
    }

    public class RisingDb_SnappingPoint
    {

        [JsonProperty("LocalTranslation")]
        public RisingDb_LocalTranslation LocalTranslation { get; set; }

        [JsonProperty("LocalRotation")]
        public double LocalRotation { get; set; }

        [JsonProperty("SnapRotation")]
        public bool SnapRotation { get; set; }

        [JsonProperty("LimitToPrefabSet")]
        public int LimitToPrefabSet { get; set; }

        [JsonProperty("OnlySnapToMatchingRotation")]
        public bool OnlySnapToMatchingRotation { get; set; }

        [JsonProperty("OnlySnapToMatchingRotationOrMirrored")]
        public bool OnlySnapToMatchingRotationOrMirrored { get; set; }
    }

    public class RisingDb_SnappingPointClosestTo
    {

        [JsonProperty("SnappingPointIndex")]
        public int SnappingPointIndex { get; set; }

        [JsonProperty("Radius")]
        public double Radius { get; set; }
    }

    public class RisingDb_ScriptReference
    {

        [JsonProperty("MethodName")]
        public string MethodName { get; set; }

        [JsonProperty("TypeName")]
        public string TypeName { get; set; }
    }

    public class RisingDb_RunScriptOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }

        [JsonProperty("ScriptReference")]
        public RisingDb_ScriptReference ScriptReference { get; set; }
    }

    public class RisingDb_SequenceGuid3
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_BuffSequence
    {

        [JsonProperty("SequenceGuid")]
        public RisingDb_SequenceGuid3 SequenceGuid { get; set; }

        [JsonProperty("ConditionalIndex")]
        public int ConditionalIndex { get; set; }
    }

    public class RisingDb_SequenceGuid4
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id9
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_SequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id9 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_PreviousWeaponEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_MountBuff_Sequence_DataServer
    {

        [JsonProperty("SequenceGuid")]
        public RisingDb_SequenceGuid4 SequenceGuid { get; set; }

        [JsonProperty("SequenceState")]
        public RisingDb_SequenceState SequenceState { get; set; }

        [JsonProperty("PreviousWeaponEntity")]
        public RisingDb_PreviousWeaponEntity PreviousWeaponEntity { get; set; }
    }

    public class RisingDb_AllowJumpFromCliffsModId
    {

        [JsonProperty("Id")]
        public int Id { get; set; }
    }

    public class RisingDb_MaxAngleModId
    {

        [JsonProperty("Id")]
        public int Id { get; set; }
    }

    public class RisingDb_MovementSpeedBonusFromBloodBuffs
    {

        [JsonProperty("Id")]
        public int Id { get; set; }
    }

    public class RisingDb_MountBuff
    {

        [JsonProperty("AllowJumpFromCliffsModId")]
        public RisingDb_AllowJumpFromCliffsModId AllowJumpFromCliffsModId { get; set; }

        [JsonProperty("MaxAngleModId")]
        public RisingDb_MaxAngleModId MaxAngleModId { get; set; }

        [JsonProperty("MovementSpeedBonusFromBloodBuffs")]
        public RisingDb_MovementSpeedBonusFromBloodBuffs MovementSpeedBonusFromBloodBuffs { get; set; }

        [JsonProperty("FeedProgressTime")]
        public double FeedProgressTime { get; set; }

        [JsonProperty("FeedTime")]
        public double FeedTime { get; set; }

        [JsonProperty("IsFed")]
        public bool IsFed { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("MaxHealth")]
        public double MaxHealth { get; set; }

        [JsonProperty("Health")]
        public double Health { get; set; }
    }

    public class RisingDb_ReplaceAbilityOnSlotBuff
    {

        [JsonProperty("Target")]
        public string Target { get; set; }

        [JsonProperty("Slot")]
        public int Slot { get; set; }

        [JsonProperty("ReplaceGroupId")]
        public int ReplaceGroupId { get; set; }

        [JsonProperty("NewGroupId")]
        public int NewGroupId { get; set; }

        [JsonProperty("Priority")]
        public int Priority { get; set; }

        [JsonProperty("ConditionalId")]
        public int ConditionalId { get; set; }
    }

    public class RisingDb_EventId5
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_CreateGameplayEventOnDamageTaken
    {

        [JsonProperty("EventId")]
        public RisingDb_EventId5 EventId { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }

        [JsonProperty("Source")]
        public string Source { get; set; }

        [JsonProperty("IncludeDoTs")]
        public bool IncludeDoTs { get; set; }
    }

    public class RisingDb_EventId6
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_CreateGameplayEventsOnDestroy
    {

        [JsonProperty("EventId")]
        public RisingDb_EventId6 EventId { get; set; }

        [JsonProperty("Target")]
        public string Target { get; set; }

        [JsonProperty("SpecificDestroyReason")]
        public bool SpecificDestroyReason { get; set; }

        [JsonProperty("DestroyReason")]
        public string DestroyReason { get; set; }
    }

    public class RisingDb_SpawnExitOffset
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb__Entity26
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_RespawnPointOwner
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity26 _Entity { get; set; }
    }

    public class RisingDb_RespawnPoint
    {

        [JsonProperty("SpawnExitOffset")]
        public RisingDb_SpawnExitOffset SpawnExitOffset { get; set; }

        [JsonProperty("SpawnDelayBuff")]
        public int SpawnDelayBuff { get; set; }

        [JsonProperty("SpawnSleepingBuff")]
        public int SpawnSleepingBuff { get; set; }

        [JsonProperty("RespawnPointType")]
        public string RespawnPointType { get; set; }

        [JsonProperty("RespawnPointOwner")]
        public RisingDb_RespawnPointOwner RespawnPointOwner { get; set; }
    }

    public class RisingDb__Entity27
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Owner2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity27 _Entity { get; set; }
    }

    public class RisingDb_UserOwner
    {

        [JsonProperty("Owner")]
        public RisingDb_Owner2 Owner { get; set; }
    }

    public class RisingDb_AttachMapIconsToEntity
    {

        [JsonProperty("Prefab")]
        public int Prefab { get; set; }
    }

    public class RisingDb_MapIconPerUserData
    {

        [JsonProperty("HasBeenCreated")]
        public bool HasBeenCreated { get; set; }
    }

    public class RisingDb_ChunkWaypoint
    {

        [JsonProperty("DefaultUnlocked")]
        public bool DefaultUnlocked { get; set; }

        [JsonProperty("CustomTeleportBuff")]
        public int CustomTeleportBuff { get; set; }
    }

    public class RisingDb_Entity4
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_FadeOutBuffer
    {

        [JsonProperty("Entity")]
        public RisingDb_Entity4 Entity { get; set; }
    }

    public class RisingDb_SequenceGuid5
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_SpawnEntitySequence
    {

        [JsonProperty("SequenceGuid")]
        public RisingDb_SequenceGuid5 SequenceGuid { get; set; }
    }

    public class RisingDb_InteractionEndSequenceGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id10
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_InteractionEndSequence
    {

        [JsonProperty("Id")]
        public RisingDb_Id10 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_EndInteractableSequence
    {

        [JsonProperty("InteractionEndSequenceGuid")]
        public RisingDb_InteractionEndSequenceGuid InteractionEndSequenceGuid { get; set; }

        [JsonProperty("InteractionEndSequence")]
        public RisingDb_InteractionEndSequence InteractionEndSequence { get; set; }
    }

    public class RisingDb_NameableInteractable
    {

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("OnlyAllyRename")]
        public bool OnlyAllyRename { get; set; }

        [JsonProperty("OnlyAllySee")]
        public bool OnlyAllySee { get; set; }
    }

    public class RisingDb_Restricted_InventoryBuffer
    {

        [JsonProperty("RestrictedType")]
        public int RestrictedType { get; set; }

        [JsonProperty("RestrictedItemCategory")]
        public string RestrictedItemCategory { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_DestroyAfterDuration
    {

        [JsonProperty("Duration")]
        public double Duration { get; set; }

        [JsonProperty("EndTime")]
        public double EndTime { get; set; }

        [JsonProperty("ConditionId")]
        public int ConditionId { get; set; }
    }

    public class RisingDb_Curve
    {

        [JsonProperty("CurveGuid")]
        public int CurveGuid { get; set; }

        [JsonProperty("FlipY")]
        public bool FlipY { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_BloodConsumeSource
    {

        [JsonProperty("UnitBloodType")]
        public int UnitBloodType { get; set; }

        [JsonProperty("Curve")]
        public RisingDb_Curve Curve { get; set; }

        [JsonProperty("BloodQuality")]
        public double BloodQuality { get; set; }

        [JsonProperty("CanBeConsumed")]
        public bool CanBeConsumed { get; set; }
    }

    public class RisingDb_WoundedTriggerSequenceGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_WoundedSequenceGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_StunMode
    {

        [JsonProperty("FixedElementField")]
        public int FixedElementField { get; set; }
    }

    public class RisingDb_UseWeaponLevel
    {

        [JsonProperty("FixedElementField")]
        public bool FixedElementField { get; set; }
    }

    public class RisingDb_WeaponLevel
    {

        [JsonProperty("FixedElementField")]
        public int FixedElementField { get; set; }
    }

    public class RisingDb_DistanceFactor
    {

        [JsonProperty("FixedElementField")]
        public double FixedElementField { get; set; }
    }

    public class RisingDb_DurationFactor
    {

        [JsonProperty("FixedElementField")]
        public double FixedElementField { get; set; }
    }

    public class RisingDb_KnockbackPower
    {

        [JsonProperty("Importance")]
        public int Importance { get; set; }

        [JsonProperty("StunMode")]
        public RisingDb_StunMode StunMode { get; set; }

        [JsonProperty("UseWeaponLevel")]
        public RisingDb_UseWeaponLevel UseWeaponLevel { get; set; }

        [JsonProperty("WeaponLevel")]
        public RisingDb_WeaponLevel WeaponLevel { get; set; }

        [JsonProperty("DistanceFactor")]
        public RisingDb_DistanceFactor DistanceFactor { get; set; }

        [JsonProperty("DurationFactor")]
        public RisingDb_DurationFactor DurationFactor { get; set; }
    }

    public class RisingDb_WoundedConstants
    {

        [JsonProperty("HealthFactor")]
        public double HealthFactor { get; set; }

        [JsonProperty("WoundedTriggerSequenceGuid")]
        public RisingDb_WoundedTriggerSequenceGuid WoundedTriggerSequenceGuid { get; set; }

        [JsonProperty("WoundedSequenceGuid")]
        public RisingDb_WoundedSequenceGuid WoundedSequenceGuid { get; set; }

        [JsonProperty("TriggerKnockbackOnWounded")]
        public bool TriggerKnockbackOnWounded { get; set; }

        [JsonProperty("KnockbackPower")]
        public RisingDb_KnockbackPower KnockbackPower { get; set; }

        [JsonProperty("KnockbackDuration")]
        public double KnockbackDuration { get; set; }

        [JsonProperty("KnockbackRange")]
        public double KnockbackRange { get; set; }

        [JsonProperty("WoundedKnockbackResistanceIndex")]
        public int WoundedKnockbackResistanceIndex { get; set; }
    }

    public class RisingDb_Force
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_DeathRagdollForce
    {

        [JsonProperty("Force")]
        public RisingDb_Force Force { get; set; }
    }

    public class RisingDb_AbilityChargesState
    {

        [JsonProperty("CurrentCharges")]
        public int CurrentCharges { get; set; }

        [JsonProperty("ChargeTime")]
        public double ChargeTime { get; set; }
    }

    public class RisingDb_AbilityChargesData
    {

        [JsonProperty("IgnoreCooldownModifier")]
        public bool IgnoreCooldownModifier { get; set; }

        [JsonProperty("MaxCharges")]
        public int MaxCharges { get; set; }

        [JsonProperty("ChargeUpTime")]
        public double ChargeUpTime { get; set; }
    }

    public class RisingDb_Entity5
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_WallpaperFadeOutBuffer
    {

        [JsonProperty("Entity")]
        public RisingDb_Entity5 Entity { get; set; }
    }

    public class RisingDb_AbilityInterruptData
    {

        [JsonProperty("CooldownOnInterrupt")]
        public double CooldownOnInterrupt { get; set; }

        [JsonProperty("InterruptTypes")]
        public string InterruptTypes { get; set; }
    }

    public class RisingDb_AbilityIgnoreSettings
    {

        [JsonProperty("IgnorePostCast")]
        public bool IgnorePostCast { get; set; }

        [JsonProperty("IgnoreGlobalCooldown")]
        public bool IgnoreGlobalCooldown { get; set; }

        [JsonProperty("IgnoreAbilityImpair")]
        public bool IgnoreAbilityImpair { get; set; }
    }

    public class RisingDb_VBloodPortraitData
    {

        [JsonProperty("HeadPortrait")]
        public string HeadPortrait { get; set; }

        [JsonProperty("FullBodyPortrait")]
        public string FullBodyPortrait { get; set; }
    }

    public class RisingDb_QuestFlavorTextOverride
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public object Text { get; set; }
    }

    public class RisingDb_VBloodConsumeSource
    {

        [JsonProperty("Source")]
        public int Source { get; set; }

        [JsonProperty("RequiresDiscovering")]
        public bool RequiresDiscovering { get; set; }

        [JsonProperty("JournalCategory")]
        public string JournalCategory { get; set; }

        [JsonProperty("QuestFlavorTextOverride")]
        public RisingDb_QuestFlavorTextOverride QuestFlavorTextOverride { get; set; }

        [JsonProperty("TooltipGUID")]
        public int TooltipGUID { get; set; }

        [JsonProperty("ItemRequirement")]
        public int ItemRequirement { get; set; }
    }

    public class RisingDb_VBloodUnit
    {

        [JsonProperty("CanBeTracked")]
        public bool CanBeTracked { get; set; }
    }

    public class RisingDb_SequenceGuid6
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_CombatMusicSource_Client
    {

        [JsonProperty("SequenceGuid")]
        public RisingDb_SequenceGuid6 SequenceGuid { get; set; }
    }

    public class RisingDb_VBloodUnlockTechBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }
    }

    public class RisingDb_Offset4
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_RadialZone_Environment_HitSpheres
    {

        [JsonProperty("Offset")]
        public RisingDb_Offset4 Offset { get; set; }

        [JsonProperty("Radius")]
        public double Radius { get; set; }
    }

    public class RisingDb_MaterialModifiers
    {

        [JsonProperty("Human")]
        public double Human { get; set; }

        [JsonProperty("Undead")]
        public double Undead { get; set; }

        [JsonProperty("Demon")]
        public double Demon { get; set; }

        [JsonProperty("Mechanical")]
        public double Mechanical { get; set; }

        [JsonProperty("Beast")]
        public double Beast { get; set; }

        [JsonProperty("CastleObject")]
        public double CastleObject { get; set; }

        [JsonProperty("PlayerVampire")]
        public double PlayerVampire { get; set; }

        [JsonProperty("BasicStructure")]
        public double BasicStructure { get; set; }

        [JsonProperty("ReinforcedStructure")]
        public double ReinforcedStructure { get; set; }

        [JsonProperty("FortifiedStructure")]
        public double FortifiedStructure { get; set; }

        [JsonProperty("StoneStructure")]
        public double StoneStructure { get; set; }

        [JsonProperty("SiegeAltar")]
        public double SiegeAltar { get; set; }

        [JsonProperty("Wood")]
        public double Wood { get; set; }

        [JsonProperty("Minerals")]
        public double Minerals { get; set; }

        [JsonProperty("Vegetation")]
        public double Vegetation { get; set; }

        [JsonProperty("LightArmor")]
        public double LightArmor { get; set; }

        [JsonProperty("VBlood")]
        public double VBlood { get; set; }

        [JsonProperty("Magic")]
        public double Magic { get; set; }

        [JsonProperty("Explosives")]
        public double Explosives { get; set; }

        [JsonProperty("MassiveResource")]
        public double MassiveResource { get; set; }
    }

    public class RisingDb_Parameters
    {

        [JsonProperty("MainFactor")]
        public double MainFactor { get; set; }

        [JsonProperty("MainType")]
        public string MainType { get; set; }

        [JsonProperty("ResourceFactor")]
        public double ResourceFactor { get; set; }

        [JsonProperty("ResourceModifier")]
        public double ResourceModifier { get; set; }

        [JsonProperty("SiegeFactor")]
        public double SiegeFactor { get; set; }

        [JsonProperty("MaterialModifiers")]
        public RisingDb_MaterialModifiers MaterialModifiers { get; set; }

        [JsonProperty("RawDamageValue")]
        public double RawDamageValue { get; set; }

        [JsonProperty("RawDamagePercent")]
        public double RawDamagePercent { get; set; }

        [JsonProperty("DealDamageFlags")]
        public int DealDamageFlags { get; set; }
    }

    public class RisingDb_DealDamageOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }

        [JsonProperty("Parameters")]
        public RisingDb_Parameters Parameters { get; set; }
    }

    public class RisingDb_EventId7
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_CreateGameplayEventsOnHit
    {

        [JsonProperty("EventId")]
        public RisingDb_EventId7 EventId { get; set; }

        [JsonProperty("HitGroup")]
        public string HitGroup { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }
    }

    public class RisingDb_HealOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("Health")]
        public double Health { get; set; }

        [JsonProperty("HealthPercent")]
        public double HealthPercent { get; set; }

        [JsonProperty("HealthPerSpellPower")]
        public double HealthPerSpellPower { get; set; }

        [JsonProperty("showSCT")]
        public bool showSCT { get; set; }

        [JsonProperty("TrueHealing")]
        public bool TrueHealing { get; set; }

        [JsonProperty("Who")]
        public string Who { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }
    }

    public class RisingDb_SequenceGuid7
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_PlayBlinkSequenceOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("SequenceGuid")]
        public RisingDb_SequenceGuid7 SequenceGuid { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }
    }

    public class RisingDb_SpawnPrefabOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("SpawnPrefab")]
        public int SpawnPrefab { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }

        [JsonProperty("SpellTarget")]
        public string SpellTarget { get; set; }

        [JsonProperty("Owner")]
        public string Owner { get; set; }
    }

    public class RisingDb_LoreText
    {

        [JsonProperty("_a")]
        public int _a { get; set; }

        [JsonProperty("_b")]
        public int _b { get; set; }

        [JsonProperty("_c")]
        public int _c { get; set; }

        [JsonProperty("_d")]
        public int _d { get; set; }

        [JsonProperty("_e")]
        public int _e { get; set; }

        [JsonProperty("_f")]
        public int _f { get; set; }

        [JsonProperty("_g")]
        public int _g { get; set; }

        [JsonProperty("_h")]
        public int _h { get; set; }

        [JsonProperty("_i")]
        public int _i { get; set; }

        [JsonProperty("_j")]
        public int _j { get; set; }

        [JsonProperty("_k")]
        public int _k { get; set; }
    }

    public class RisingDb_Script_InspectTarget_Data
    {

        [JsonProperty("LoreText")]
        public RisingDb_LoreText LoreText { get; set; }
    }

    public class RisingDb_Torture
    {

        [JsonProperty("TortureModifier")]
        public double TortureModifier { get; set; }

        [JsonProperty("TorturePerDamage")]
        public double TorturePerDamage { get; set; }
    }

    public class RisingDb_TechUnlockPassiveBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }
    }

    public class RisingDb_Empty3
    {

        [JsonProperty("Empty")]
        public object Empty { get; set; }
    }

    public class RisingDb_Empty2
    {

        [JsonProperty("Empty")]
        public RisingDb_Empty3 Empty { get; set; }
    }

    public class RisingDb_Empty
    {

        [JsonProperty("Empty")]
        public RisingDb_Empty2 Empty { get; set; }
    }

    public class RisingDb_NameKey
    {

        [JsonProperty("Empty")]
        public RisingDb_Empty Empty { get; set; }
    }

    public class RisingDb_ModifyUnitStatBuff_DOTS
    {

        [JsonProperty("StatType")]
        public string StatType { get; set; }

        [JsonProperty("ModificationType")]
        public string ModificationType { get; set; }

        [JsonProperty("Value")]
        public double Value { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("NameKey")]
        public RisingDb_NameKey NameKey { get; set; }
    }

    public class RisingDb_AttachParentId
    {

        [JsonProperty("Index")]
        public int Index { get; set; }
    }

    public class RisingDb_Entity6
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_AttachedBuffer
    {

        [JsonProperty("PrefabGuid")]
        public int PrefabGuid { get; set; }

        [JsonProperty("Entity")]
        public RisingDb_Entity6 Entity { get; set; }
    }

    public class RisingDb_FuseSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id11
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_FuseSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id11 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Script_WarningCircle_Visuals_DataClient
    {

        [JsonProperty("FuseSequence")]
        public RisingDb_FuseSequence FuseSequence { get; set; }

        [JsonProperty("FuseSequenceState")]
        public RisingDb_FuseSequenceState FuseSequenceState { get; set; }

        [JsonProperty("OverrideScale")]
        public double OverrideScale { get; set; }
    }

    public class RisingDb_Script_SCTChatOnSpawn_Data
    {

        [JsonProperty("SCTPrefab")]
        public int SCTPrefab { get; set; }
    }

    public class RisingDb_Text2
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Script_SCTChatOnSpawn_Buffer
    {

        [JsonProperty("Text")]
        public RisingDb_Text2 Text { get; set; }

        [JsonProperty("Weight")]
        public int Weight { get; set; }
    }

    public class RisingDb_SpawnChainBlueprint
    {

        [JsonProperty("BuildingPreviewPrefab")]
        public int BuildingPreviewPrefab { get; set; }
    }

    public class RisingDb_SoundEventEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Value14
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }

        [JsonProperty("z")]
        public int z { get; set; }

        [JsonProperty("w")]
        public int w { get; set; }
    }

    public class RisingDb_SoundGuid
    {

        [JsonProperty("Value")]
        public RisingDb_Value14 Value { get; set; }
    }

    public class RisingDb_IdleAISoundBuffer
    {

        [JsonProperty("SoundEventEntity")]
        public RisingDb_SoundEventEntity SoundEventEntity { get; set; }

        [JsonProperty("SoundGuid")]
        public RisingDb_SoundGuid SoundGuid { get; set; }

        [JsonProperty("StopBehaviour")]
        public string StopBehaviour { get; set; }

        [JsonProperty("StopMode")]
        public string StopMode { get; set; }

        [JsonProperty("VolumeRatio")]
        public double VolumeRatio { get; set; }

        [JsonProperty("PitchRatio")]
        public double PitchRatio { get; set; }

        [JsonProperty("Active")]
        public bool Active { get; set; }
    }

    public class RisingDb__Entity28
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Target3
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity28 _Entity { get; set; }
    }

    public class RisingDb_AbilityTarget
    {

        [JsonProperty("Target")]
        public RisingDb_Target3 Target { get; set; }

        [JsonProperty("GetTargetType")]
        public string GetTargetType { get; set; }

        [JsonProperty("Buff")]
        public int Buff { get; set; }

        [JsonProperty("BuffCategory")]
        public string BuffCategory { get; set; }
    }

    public class RisingDb__Entity29
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_UserEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity29 _Entity { get; set; }
    }

    public class RisingDb_UserTeam
    {

        [JsonProperty("UserEntity")]
        public RisingDb_UserEntity UserEntity { get; set; }
    }

    public class RisingDb__Entity30
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Value15
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity30 _Entity { get; set; }
    }

    public class RisingDb_TeamAlly
    {

        [JsonProperty("Value")]
        public RisingDb_Value15 Value { get; set; }
    }

    public class RisingDb_Parent2
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Attached
    {

        [JsonProperty("Parent")]
        public RisingDb_Parent2 Parent { get; set; }

        [JsonProperty("AttachParentIndex")]
        public int AttachParentIndex { get; set; }
    }

    public class RisingDb_Parent3
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_PhysicsParent
    {

        [JsonProperty("Parent")]
        public RisingDb_Parent3 Parent { get; set; }
    }

    public class RisingDb_Entity7
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_DoorChildren
    {

        [JsonProperty("Entity")]
        public RisingDb_Entity7 Entity { get; set; }
    }

    public class RisingDb_StartGraveyardExitWaypoint
    {

        [JsonProperty("CustomTeleportBuff")]
        public int CustomTeleportBuff { get; set; }
    }

    public class RisingDb_Door
    {
    }

    public class RisingDb_DurabilityTarget
    {

        [JsonProperty("DurabilityFactor")]
        public double DurabilityFactor { get; set; }
    }

    public class RisingDb_DeathPvPTimer
    {

        [JsonProperty("ExtraTime_FirstStack")]
        public double ExtraTime_FirstStack { get; set; }

        [JsonProperty("ExtraTime_AdditionalStacks")]
        public double ExtraTime_AdditionalStacks { get; set; }
    }

    public class RisingDb_StartPosition2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_xyz2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_value16
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz2 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw2 zw { get; set; }
    }

    public class RisingDb_StartRotation
    {

        [JsonProperty("value")]
        public RisingDb_value16 value { get; set; }
    }

    public class RisingDb_Curve2
    {

        [JsonProperty("CurveGuid")]
        public int CurveGuid { get; set; }

        [JsonProperty("FlipY")]
        public bool FlipY { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_Dash
    {

        [JsonProperty("StartPosition")]
        public RisingDb_StartPosition2 StartPosition { get; set; }

        [JsonProperty("StartRotation")]
        public RisingDb_StartRotation StartRotation { get; set; }

        [JsonProperty("Curve")]
        public RisingDb_Curve2 Curve { get; set; }

        [JsonProperty("Range")]
        public double Range { get; set; }

        [JsonProperty("StopOnMapCollision")]
        public bool StopOnMapCollision { get; set; }

        [JsonProperty("RotationMode")]
        public string RotationMode { get; set; }

        [JsonProperty("TileCollisionHitCount")]
        public int TileCollisionHitCount { get; set; }

        [JsonProperty("CurveId")]
        public int CurveId { get; set; }

        [JsonProperty("Speed")]
        public double Speed { get; set; }
    }

    public class RisingDb_GenerateAggroOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }

        [JsonProperty("From")]
        public string From { get; set; }

        [JsonProperty("Towards")]
        public string Towards { get; set; }

        [JsonProperty("Value")]
        public double Value { get; set; }
    }

    public class RisingDb_Throw_Prefabs_To_Spawn
    {

        [JsonProperty("Value")]
        public int Value { get; set; }
    }

    public class RisingDb_ServantPortraitData
    {

        [JsonProperty("NormalPortrait")]
        public string NormalPortrait { get; set; }

        [JsonProperty("VampirePortrait")]
        public string VampirePortrait { get; set; }
    }

    public class RisingDb__Entity31
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ArmorChestSlotEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity31 _Entity { get; set; }
    }

    public class RisingDb__Entity32
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_WeaponSlotEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity32 _Entity { get; set; }
    }

    public class RisingDb__Entity33
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_GrimoireSlotEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity33 _Entity { get; set; }
    }

    public class RisingDb__Entity34
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ArmorFootgearSlotEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity34 _Entity { get; set; }
    }

    public class RisingDb__Entity35
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ArmorLegsSlotEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity35 _Entity { get; set; }
    }

    public class RisingDb__Entity36
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ArmorGlovesSlotEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity36 _Entity { get; set; }
    }

    public class RisingDb_ServantEquipment
    {

        [JsonProperty("ArmorChestSlotEntity")]
        public RisingDb_ArmorChestSlotEntity ArmorChestSlotEntity { get; set; }

        [JsonProperty("ArmorChestSlotId")]
        public int ArmorChestSlotId { get; set; }

        [JsonProperty("WeaponSlotEntity")]
        public RisingDb_WeaponSlotEntity WeaponSlotEntity { get; set; }

        [JsonProperty("WeaponSlotId")]
        public int WeaponSlotId { get; set; }

        [JsonProperty("GrimoireSlotEntity")]
        public RisingDb_GrimoireSlotEntity GrimoireSlotEntity { get; set; }

        [JsonProperty("GrimoireSlotId")]
        public int GrimoireSlotId { get; set; }

        [JsonProperty("ArmorFootgearSlotEntity")]
        public RisingDb_ArmorFootgearSlotEntity ArmorFootgearSlotEntity { get; set; }

        [JsonProperty("ArmorFootgearSlotId")]
        public int ArmorFootgearSlotId { get; set; }

        [JsonProperty("ArmorLegsSlotEntity")]
        public RisingDb_ArmorLegsSlotEntity ArmorLegsSlotEntity { get; set; }

        [JsonProperty("ArmorLegsSlotId")]
        public int ArmorLegsSlotId { get; set; }

        [JsonProperty("ArmorGlovesSlotEntity")]
        public RisingDb_ArmorGlovesSlotEntity ArmorGlovesSlotEntity { get; set; }

        [JsonProperty("ArmorGlovesSlotId")]
        public int ArmorGlovesSlotId { get; set; }
    }

    public class RisingDb__Entity37
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_CoffinEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity37 _Entity { get; set; }
    }

    public class RisingDb_ServantConnectedCoffin
    {

        [JsonProperty("CoffinEntity")]
        public RisingDb_CoffinEntity CoffinEntity { get; set; }
    }

    public class RisingDb_ServantData
    {

        [JsonProperty("ConvertDuration")]
        public double ConvertDuration { get; set; }

        [JsonProperty("ReviveDuration")]
        public double ReviveDuration { get; set; }

        [JsonProperty("ReviveCostModifier")]
        public double ReviveCostModifier { get; set; }

        [JsonProperty("IsOnMission")]
        public bool IsOnMission { get; set; }
    }

    public class RisingDb_ServantPower
    {

        [JsonProperty("BaseLevel")]
        public int BaseLevel { get; set; }

        [JsonProperty("GearLevel")]
        public double GearLevel { get; set; }

        [JsonProperty("GearProfficiency")]
        public double GearProfficiency { get; set; }
    }

    public class RisingDb_ServantTypeData
    {

        [JsonProperty("ServantType")]
        public string ServantType { get; set; }

        [JsonProperty("GenderType")]
        public string GenderType { get; set; }
    }

    public class RisingDb_NPCServantColorIndex
    {

        [JsonProperty("EyeColorIndex")]
        public int EyeColorIndex { get; set; }
    }

    public class RisingDb_ServantConvertable
    {

        [JsonProperty("ConvertToUnit")]
        public int ConvertToUnit { get; set; }
    }

    public class RisingDb_PerksBuffer
    {

        [JsonProperty("Perk")]
        public int Perk { get; set; }
    }

    public class RisingDb_ServantConvertRequirement
    {

        [JsonProperty("Item")]
        public int Item { get; set; }

        [JsonProperty("Amount")]
        public int Amount { get; set; }
    }

    public class RisingDb_UnitLevelDamageSetting
    {

        [JsonProperty("LevelDiff")]
        public double LevelDiff { get; set; }

        [JsonProperty("IncomingDamageModifier")]
        public double IncomingDamageModifier { get; set; }

        [JsonProperty("OutgoingDamageModifier")]
        public double OutgoingDamageModifier { get; set; }
    }

    public class RisingDb_RotationCurve
    {

        [JsonProperty("CurveGuid")]
        public int CurveGuid { get; set; }

        [JsonProperty("FlipY")]
        public bool FlipY { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_xyz3
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw3
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_value17
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz3 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw3 zw { get; set; }
    }

    public class RisingDb_InitialRotation
    {

        [JsonProperty("value")]
        public RisingDb_value17 value { get; set; }
    }

    public class RisingDb_RotateOverTimeData
    {

        [JsonProperty("RotationTarget")]
        public string RotationTarget { get; set; }

        [JsonProperty("RotationType")]
        public string RotationType { get; set; }

        [JsonProperty("RotationAngle")]
        public double RotationAngle { get; set; }

        [JsonProperty("RotationCurve")]
        public RisingDb_RotationCurve RotationCurve { get; set; }

        [JsonProperty("UseCustomDuration")]
        public bool UseCustomDuration { get; set; }

        [JsonProperty("CustomDuration")]
        public double CustomDuration { get; set; }

        [JsonProperty("InitialRotation")]
        public RisingDb_InitialRotation InitialRotation { get; set; }
    }

    public class RisingDb_FuseSequence2
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id12
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_FuseSequenceState2
    {

        [JsonProperty("Id")]
        public RisingDb_Id12 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Script_WarningCircle_Buff_Visuals_DataClient
    {

        [JsonProperty("FuseSequence")]
        public RisingDb_FuseSequence2 FuseSequence { get; set; }

        [JsonProperty("FuseSequenceState")]
        public RisingDb_FuseSequenceState2 FuseSequenceState { get; set; }
    }

    public class RisingDb__Entity38
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_AbilityGroup
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity38 _Entity { get; set; }
    }

    public class RisingDb__Entity39
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Ability
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity39 _Entity { get; set; }
    }

    public class RisingDb_AbilityOwner
    {

        [JsonProperty("AbilityGroup")]
        public RisingDb_AbilityGroup AbilityGroup { get; set; }

        [JsonProperty("Ability")]
        public RisingDb_Ability Ability { get; set; }
    }

    public class RisingDb_ActiveSequenceGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id13
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ActiveSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id13 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_InactiveSequenceGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id14
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_InactiveSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id14 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_UnitSpawnerstation
    {

        [JsonProperty("MaxSpawnedUnits")]
        public int MaxSpawnedUnits { get; set; }

        [JsonProperty("SpawnRadiusMin")]
        public double SpawnRadiusMin { get; set; }

        [JsonProperty("SpawnRadiusMax")]
        public double SpawnRadiusMax { get; set; }

        [JsonProperty("OnDestroyAction")]
        public string OnDestroyAction { get; set; }

        [JsonProperty("CurrentRecipeGuid")]
        public int CurrentRecipeGuid { get; set; }

        [JsonProperty("Progress")]
        public double Progress { get; set; }

        [JsonProperty("IsWorking")]
        public bool IsWorking { get; set; }

        [JsonProperty("ActiveSequenceGuid")]
        public RisingDb_ActiveSequenceGuid ActiveSequenceGuid { get; set; }

        [JsonProperty("ActiveSequenceState")]
        public RisingDb_ActiveSequenceState ActiveSequenceState { get; set; }

        [JsonProperty("InactiveSequenceGuid")]
        public RisingDb_InactiveSequenceGuid InactiveSequenceGuid { get; set; }

        [JsonProperty("InactiveSequenceState")]
        public RisingDb_InactiveSequenceState InactiveSequenceState { get; set; }
    }

    public class RisingDb_RefinementstationRecipesBuffer
    {

        [JsonProperty("RecipeGuid")]
        public int RecipeGuid { get; set; }

        [JsonProperty("Unlocked")]
        public bool Unlocked { get; set; }
    }

    public class RisingDb_Wallpaper_NotSplit
    {

        [JsonProperty("ActiveIndex")]
        public int ActiveIndex { get; set; }

        [JsonProperty("CurrentIndex")]
        public int CurrentIndex { get; set; }

        [JsonProperty("ActiveOverride")]
        public int ActiveOverride { get; set; }

        [JsonProperty("OverrideOrientation")]
        public string OverrideOrientation { get; set; }
    }

    public class RisingDb_WallpaperStyles
    {
    }

    public class RisingDb_WallpaperForceDamaged
    {

        [JsonProperty("Value")]
        public bool Value { get; set; }
    }

    public class RisingDb_ActiveSequenceGuid2
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_InactiveSequenceGuid2
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id15
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ActiveSequenceState2
    {

        [JsonProperty("Id")]
        public RisingDb_Id15 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Id16
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_InactiveSequenceState2
    {

        [JsonProperty("Id")]
        public RisingDb_Id16 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_ClaimGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_LevelUpGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_DestroyGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Pylonstation
    {

        [JsonProperty("CurrentRecipeGuid")]
        public int CurrentRecipeGuid { get; set; }

        [JsonProperty("Progress")]
        public double Progress { get; set; }

        [JsonProperty("SpeedModifier")]
        public double SpeedModifier { get; set; }

        [JsonProperty("FloorCount")]
        public int FloorCount { get; set; }

        [JsonProperty("PylonCount")]
        public int PylonCount { get; set; }

        [JsonProperty("ServantCount")]
        public int ServantCount { get; set; }

        [JsonProperty("Level")]
        public int Level { get; set; }

        [JsonProperty("BurnRate")]
        public int BurnRate { get; set; }

        [JsonProperty("MinutesRemaining")]
        public int MinutesRemaining { get; set; }

        [JsonProperty("FuelAmount")]
        public int FuelAmount { get; set; }

        [JsonProperty("FuelPercentage")]
        public double FuelPercentage { get; set; }

        [JsonProperty("TombCount")]
        public int TombCount { get; set; }

        [JsonProperty("NestCount")]
        public int NestCount { get; set; }

        [JsonProperty("SafetyBoxCount")]
        public int SafetyBoxCount { get; set; }

        [JsonProperty("SlotsPerLevel")]
        public int SlotsPerLevel { get; set; }

        [JsonProperty("ActiveSequenceGuid")]
        public RisingDb_ActiveSequenceGuid2 ActiveSequenceGuid { get; set; }

        [JsonProperty("InactiveSequenceGuid")]
        public RisingDb_InactiveSequenceGuid2 InactiveSequenceGuid { get; set; }

        [JsonProperty("ActiveSequenceState")]
        public RisingDb_ActiveSequenceState2 ActiveSequenceState { get; set; }

        [JsonProperty("InactiveSequenceState")]
        public RisingDb_InactiveSequenceState2 InactiveSequenceState { get; set; }

        [JsonProperty("ClaimGuid")]
        public RisingDb_ClaimGuid ClaimGuid { get; set; }

        [JsonProperty("LevelUpGuid")]
        public RisingDb_LevelUpGuid LevelUpGuid { get; set; }

        [JsonProperty("DestroyGuid")]
        public RisingDb_DestroyGuid DestroyGuid { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("IsWorking")]
        public bool IsWorking { get; set; }

        [JsonProperty("ChangedStateThisFrame")]
        public bool ChangedStateThisFrame { get; set; }

        [JsonProperty("IsProcessing")]
        public bool IsProcessing { get; set; }
    }

    public class RisingDb_CastleHeart
    {

        [JsonProperty("CastleSiegeEndTime")]
        public double CastleSiegeEndTime { get; set; }

        [JsonProperty("MinorCastleSiegeEndTime")]
        public double MinorCastleSiegeEndTime { get; set; }

        [JsonProperty("LastAnnouncementTime")]
        public double LastAnnouncementTime { get; set; }
    }

    public class RisingDb_PylonstationUpgradesBuffer
    {

        [JsonProperty("UpgradeGuid")]
        public int UpgradeGuid { get; set; }
    }

    public class RisingDb_PylonstationCastleClaimBuffer
    {

        [JsonProperty("CastleClaimGuid")]
        public int CastleClaimGuid { get; set; }
    }

    public class RisingDb_PylonstationCastleDestroyBuffer
    {

        [JsonProperty("CastleDestroyGuid")]
        public int CastleDestroyGuid { get; set; }
    }

    public class RisingDb_Wallpaper_TwoSplits
    {

        [JsonProperty("ActiveIndex_0")]
        public int ActiveIndex_0 { get; set; }

        [JsonProperty("ActiveIndex_180")]
        public int ActiveIndex_180 { get; set; }

        [JsonProperty("CurrentIndex_0")]
        public int CurrentIndex_0 { get; set; }

        [JsonProperty("CurrentIndex_180")]
        public int CurrentIndex_180 { get; set; }

        [JsonProperty("ActiveOverride")]
        public int ActiveOverride { get; set; }

        [JsonProperty("OverrideOrientation")]
        public string OverrideOrientation { get; set; }
    }

    public class RisingDb__Entity40
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_InputInventoryEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity40 _Entity { get; set; }
    }

    public class RisingDb__Entity41
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_OutputInventoryEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity41 _Entity { get; set; }
    }

    public class RisingDb_ActiveSequenceGuid3
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_InactiveSequenceGuid3
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id17
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ActiveSequenceState3
    {

        [JsonProperty("Id")]
        public RisingDb_Id17 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Id18
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_InactiveSequenceState3
    {

        [JsonProperty("Id")]
        public RisingDb_Id18 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Refinementstation
    {

        [JsonProperty("InputInventoryEntity")]
        public RisingDb_InputInventoryEntity InputInventoryEntity { get; set; }

        [JsonProperty("OutputInventoryEntity")]
        public RisingDb_OutputInventoryEntity OutputInventoryEntity { get; set; }

        [JsonProperty("Active")]
        public bool Active { get; set; }

        [JsonProperty("CurrentRecipeGuid")]
        public int CurrentRecipeGuid { get; set; }

        [JsonProperty("Progress")]
        public double Progress { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("IsWorking")]
        public bool IsWorking { get; set; }

        [JsonProperty("InventoryPrefabGuid")]
        public int InventoryPrefabGuid { get; set; }

        [JsonProperty("ActiveSequenceGuid")]
        public RisingDb_ActiveSequenceGuid3 ActiveSequenceGuid { get; set; }

        [JsonProperty("InactiveSequenceGuid")]
        public RisingDb_InactiveSequenceGuid3 InactiveSequenceGuid { get; set; }

        [JsonProperty("ActiveSequenceState")]
        public RisingDb_ActiveSequenceState3 ActiveSequenceState { get; set; }

        [JsonProperty("InactiveSequenceState")]
        public RisingDb_InactiveSequenceState3 InactiveSequenceState { get; set; }
    }

    public class RisingDb_Wallpaper_FourSplits
    {

        [JsonProperty("ActiveIndex_0")]
        public int ActiveIndex_0 { get; set; }

        [JsonProperty("ActiveIndex_90")]
        public int ActiveIndex_90 { get; set; }

        [JsonProperty("ActiveIndex_180")]
        public int ActiveIndex_180 { get; set; }

        [JsonProperty("ActiveIndex_270")]
        public int ActiveIndex_270 { get; set; }

        [JsonProperty("CurrentIndex_0")]
        public int CurrentIndex_0 { get; set; }

        [JsonProperty("CurrentIndex_90")]
        public int CurrentIndex_90 { get; set; }

        [JsonProperty("CurrentIndex_180")]
        public int CurrentIndex_180 { get; set; }

        [JsonProperty("CurrentIndex_270")]
        public int CurrentIndex_270 { get; set; }

        [JsonProperty("ActiveOverride")]
        public int ActiveOverride { get; set; }

        [JsonProperty("OverrideOrientation")]
        public string OverrideOrientation { get; set; }
    }

    public class RisingDb_ActiveSequenceGuid4
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id19
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ActiveSequenceState4
    {

        [JsonProperty("Id")]
        public RisingDb_Id19 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_InactiveSequenceGuid4
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id20
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_InactiveSequenceState4
    {

        [JsonProperty("Id")]
        public RisingDb_Id20 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_ResearchCompletedGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_ResearchStation
    {

        [JsonProperty("ActiveSequenceGuid")]
        public RisingDb_ActiveSequenceGuid4 ActiveSequenceGuid { get; set; }

        [JsonProperty("ActiveSequenceState")]
        public RisingDb_ActiveSequenceState4 ActiveSequenceState { get; set; }

        [JsonProperty("InactiveSequenceGuid")]
        public RisingDb_InactiveSequenceGuid4 InactiveSequenceGuid { get; set; }

        [JsonProperty("InactiveSequenceState")]
        public RisingDb_InactiveSequenceState4 InactiveSequenceState { get; set; }

        [JsonProperty("ResearchCompletedGuid")]
        public RisingDb_ResearchCompletedGuid ResearchCompletedGuid { get; set; }
    }

    public class RisingDb_HaveUnlocksInStation
    {

        [JsonProperty("CanUnlock")]
        public bool CanUnlock { get; set; }
    }

    public class RisingDb_DiscoverCostBuffer
    {

        [JsonProperty("PrefabGUID")]
        public int PrefabGUID { get; set; }

        [JsonProperty("Stacks")]
        public int Stacks { get; set; }
    }

    public class RisingDb_ResearchBuffer
    {

        [JsonProperty("ResearchGuid")]
        public int ResearchGuid { get; set; }

        [JsonProperty("IsResearchByStation")]
        public bool IsResearchByStation { get; set; }
    }

    public class RisingDb__Entity42
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_InputInventoryEntity2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity42 _Entity { get; set; }
    }

    public class RisingDb__Entity43
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_OutputInventoryEntity2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity43 _Entity { get; set; }
    }

    public class RisingDb_ActiveSequenceGuid5
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_InactiveSequenceGuid5
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id21
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ActiveSequenceState5
    {

        [JsonProperty("Id")]
        public RisingDb_Id21 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Id22
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_InactiveSequenceState5
    {

        [JsonProperty("Id")]
        public RisingDb_Id22 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Salvagestation
    {

        [JsonProperty("InputInventoryEntity")]
        public RisingDb_InputInventoryEntity2 InputInventoryEntity { get; set; }

        [JsonProperty("OutputInventoryEntity")]
        public RisingDb_OutputInventoryEntity2 OutputInventoryEntity { get; set; }

        [JsonProperty("Active")]
        public bool Active { get; set; }

        [JsonProperty("CurrentItemGuid")]
        public int CurrentItemGuid { get; set; }

        [JsonProperty("Progress")]
        public double Progress { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("IsWorking")]
        public bool IsWorking { get; set; }

        [JsonProperty("InventoryPrefabGuid")]
        public int InventoryPrefabGuid { get; set; }

        [JsonProperty("ActiveSequenceGuid")]
        public RisingDb_ActiveSequenceGuid5 ActiveSequenceGuid { get; set; }

        [JsonProperty("InactiveSequenceGuid")]
        public RisingDb_InactiveSequenceGuid5 InactiveSequenceGuid { get; set; }

        [JsonProperty("ActiveSequenceState")]
        public RisingDb_ActiveSequenceState5 ActiveSequenceState { get; set; }

        [JsonProperty("InactiveSequenceState")]
        public RisingDb_InactiveSequenceState5 InactiveSequenceState { get; set; }
    }

    public class RisingDb_Relic
    {

        [JsonProperty("RelicType")]
        public string RelicType { get; set; }
    }

    public class RisingDb_ActiveSequenceGuid6
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id23
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ActiveSequenceState6
    {

        [JsonProperty("Id")]
        public RisingDb_Id23 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Bonfire
    {

        [JsonProperty("IsActive")]
        public bool IsActive { get; set; }

        [JsonProperty("Strength")]
        public double Strength { get; set; }

        [JsonProperty("InputItem")]
        public int InputItem { get; set; }

        [JsonProperty("BurnTime")]
        public double BurnTime { get; set; }

        [JsonProperty("TimeToGetToFullStrength")]
        public double TimeToGetToFullStrength { get; set; }

        [JsonProperty("TimeToGetToZeroStrength")]
        public double TimeToGetToZeroStrength { get; set; }

        [JsonProperty("StartScale")]
        public double StartScale { get; set; }

        [JsonProperty("EndScale")]
        public double EndScale { get; set; }

        [JsonProperty("ActiveSequenceGuid")]
        public RisingDb_ActiveSequenceGuid6 ActiveSequenceGuid { get; set; }

        [JsonProperty("ActiveSequenceState")]
        public RisingDb_ActiveSequenceState6 ActiveSequenceState { get; set; }
    }

    public class RisingDb_BurnContainer
    {

        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("Progress")]
        public double Progress { get; set; }
    }

    public class RisingDb_Speed
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_CloudCookie
    {

        [JsonProperty("Speed")]
        public RisingDb_Speed Speed { get; set; }

        [JsonProperty("Alpha")]
        public double Alpha { get; set; }

        [JsonProperty("Size")]
        public double Size { get; set; }

        [JsonProperty("Scale")]
        public double Scale { get; set; }

        [JsonProperty("VolumetricMultiplier")]
        public double VolumetricMultiplier { get; set; }

        [JsonProperty("WrapMode")]
        public string WrapMode { get; set; }

        [JsonProperty("InvertColors")]
        public bool InvertColors { get; set; }

        [JsonProperty("TextureIndex")]
        public int TextureIndex { get; set; }

        [JsonProperty("MipLevel")]
        public int MipLevel { get; set; }
    }

    public class RisingDb_InfoText
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_ManagedRepairStationData
    {

        [JsonProperty("InfoSprite")]
        public string InfoSprite { get; set; }

        [JsonProperty("InfoText")]
        public RisingDb_InfoText InfoText { get; set; }
    }

    public class RisingDb_RepairstationData
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }
    }

    public class RisingDb_PlaySequenceOnRepair
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Repairstation
    {

        [JsonProperty("SpawnOnRepairPrefab")]
        public int SpawnOnRepairPrefab { get; set; }

        [JsonProperty("TransferTeamToRepairerTeam")]
        public bool TransferTeamToRepairerTeam { get; set; }

        [JsonProperty("ClaimCastleAreaOnRepair")]
        public bool ClaimCastleAreaOnRepair { get; set; }

        [JsonProperty("PlaySequenceOnRepair")]
        public RisingDb_PlaySequenceOnRepair PlaySequenceOnRepair { get; set; }
    }

    public class RisingDb_RepairRequirementBuffer
    {

        [JsonProperty("ItemGuid")]
        public int ItemGuid { get; set; }

        [JsonProperty("RequiredAmount")]
        public int RequiredAmount { get; set; }
    }

    public class RisingDb_UnlockGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_BloodAltar
    {

        [JsonProperty("UnlockGuid")]
        public RisingDb_UnlockGuid UnlockGuid { get; set; }

        [JsonProperty("TrackPrefabGuid")]
        public int TrackPrefabGuid { get; set; }
    }

    public class RisingDb_BloodHuntBuffer
    {

        [JsonProperty("BloodHuntTarget")]
        public int BloodHuntTarget { get; set; }

        [JsonProperty("IsUnlockedByStation")]
        public bool IsUnlockedByStation { get; set; }
    }

    public class RisingDb_UpgradeableFromTileModel
    {
    }

    public class RisingDb__Entity44
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ConnectedServant
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity44 _Entity { get; set; }
    }

    public class RisingDb_ServantCoffinstation
    {

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("ConvertFromUnit")]
        public int ConvertFromUnit { get; set; }

        [JsonProperty("ConvertToUnit")]
        public int ConvertToUnit { get; set; }

        [JsonProperty("BloodQuality")]
        public double BloodQuality { get; set; }

        [JsonProperty("ConvertionProgress")]
        public double ConvertionProgress { get; set; }

        [JsonProperty("ServantName")]
        public string ServantName { get; set; }

        [JsonProperty("ConnectedServant")]
        public RisingDb_ConnectedServant ConnectedServant { get; set; }

        [JsonProperty("RecuperateEndTime")]
        public double RecuperateEndTime { get; set; }

        [JsonProperty("Injury")]
        public int Injury { get; set; }

        [JsonProperty("ConnectedServantState")]
        public string ConnectedServantState { get; set; }

        [JsonProperty("ServantSeed")]
        public int ServantSeed { get; set; }

        [JsonProperty("ServantEyeColorIndex")]
        public int ServantEyeColorIndex { get; set; }
    }

    public class RisingDb_LKey_RequiresPhsycicForm
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb__Entity45
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ImprisonedEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity45 _Entity { get; set; }
    }

    public class RisingDb_PrisonCell
    {

        [JsonProperty("Buff_PhsicicForm")]
        public int Buff_PhsicicForm { get; set; }

        [JsonProperty("LKey_RequiresPhsycicForm")]
        public RisingDb_LKey_RequiresPhsycicForm LKey_RequiresPhsycicForm { get; set; }

        [JsonProperty("ImprisonedEntity")]
        public RisingDb_ImprisonedEntity ImprisonedEntity { get; set; }
    }

    public class RisingDb_StartPosition3
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_EndPosition2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Curve3
    {

        [JsonProperty("CurveGuid")]
        public int CurveGuid { get; set; }

        [JsonProperty("FlipY")]
        public bool FlipY { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_HeightCurve
    {

        [JsonProperty("CurveGuid")]
        public int CurveGuid { get; set; }

        [JsonProperty("FlipY")]
        public bool FlipY { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_TravelBuff
    {

        [JsonProperty("StartPosition")]
        public RisingDb_StartPosition3 StartPosition { get; set; }

        [JsonProperty("EndPosition")]
        public RisingDb_EndPosition2 EndPosition { get; set; }

        [JsonProperty("Curve")]
        public RisingDb_Curve3 Curve { get; set; }

        [JsonProperty("HeightCurve")]
        public RisingDb_HeightCurve HeightCurve { get; set; }

        [JsonProperty("Height")]
        public double Height { get; set; }

        [JsonProperty("RotationMode")]
        public string RotationMode { get; set; }

        [JsonProperty("CurveId")]
        public int CurveId { get; set; }

        [JsonProperty("MaxHeightDiff")]
        public double MaxHeightDiff { get; set; }

        [JsonProperty("ExtraDistanceAllowed")]
        public double ExtraDistanceAllowed { get; set; }

        [JsonProperty("DenyLowerHeight")]
        public bool DenyLowerHeight { get; set; }

        [JsonProperty("StopAtHighCollision")]
        public bool StopAtHighCollision { get; set; }
    }

    public class RisingDb_TravelBuffSpawn
    {

        [JsonProperty("TravelTargetMode")]
        public string TravelTargetMode { get; set; }

        [JsonProperty("TargetRangeOffset")]
        public double TargetRangeOffset { get; set; }

        [JsonProperty("MinRange")]
        public double MinRange { get; set; }

        [JsonProperty("MaxRange")]
        public double MaxRange { get; set; }

        [JsonProperty("RandomOffsetRadius")]
        public double RandomOffsetRadius { get; set; }

        [JsonProperty("ScaleDuration")]
        public bool ScaleDuration { get; set; }

        [JsonProperty("MinDuration")]
        public double MinDuration { get; set; }

        [JsonProperty("MaxDuration")]
        public double MaxDuration { get; set; }

        [JsonProperty("GetStartPositionFromBuffTarget")]
        public bool GetStartPositionFromBuffTarget { get; set; }

        [JsonProperty("IgnoreAllCollision")]
        public bool IgnoreAllCollision { get; set; }
    }

    public class RisingDb_ChunkCoordinate
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }
    }

    public class RisingDb_FromChunk
    {

        [JsonProperty("ChunkCoordinate")]
        public RisingDb_ChunkCoordinate ChunkCoordinate { get; set; }

        [JsonProperty("X")]
        public int X { get; set; }

        [JsonProperty("Y")]
        public int Y { get; set; }
    }

    public class RisingDb_ChunkCoordinate2
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }
    }

    public class RisingDb_ToChunk
    {

        [JsonProperty("ChunkCoordinate")]
        public RisingDb_ChunkCoordinate2 ChunkCoordinate { get; set; }

        [JsonProperty("X")]
        public int X { get; set; }

        [JsonProperty("Y")]
        public int Y { get; set; }
    }

    public class RisingDb_InPositionOffset
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_ChunkPortal
    {

        [JsonProperty("FromChunk")]
        public RisingDb_FromChunk FromChunk { get; set; }

        [JsonProperty("FromChunkPortalIndex")]
        public int FromChunkPortalIndex { get; set; }

        [JsonProperty("ToChunk")]
        public RisingDb_ToChunk ToChunk { get; set; }

        [JsonProperty("ToChunkPortalIndex")]
        public int ToChunkPortalIndex { get; set; }

        [JsonProperty("InPositionOffset")]
        public RisingDb_InPositionOffset InPositionOffset { get; set; }
    }

    public class RisingDb_EventId8
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_CreateGameplayEventOnItemEquipped
    {

        [JsonProperty("EventId")]
        public RisingDb_EventId8 EventId { get; set; }

        [JsonProperty("EquipmentType")]
        public string EquipmentType { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }

        [JsonProperty("Source")]
        public string Source { get; set; }

        [JsonProperty("TriggerOnUnEquip")]
        public bool TriggerOnUnEquip { get; set; }
    }

    public class RisingDb_ModificationId
    {

        [JsonProperty("Id")]
        public int Id { get; set; }
    }

    public class RisingDb_WeaponLevel2
    {

        [JsonProperty("Level")]
        public double Level { get; set; }

        [JsonProperty("ModificationId")]
        public RisingDb_ModificationId ModificationId { get; set; }
    }

    public class RisingDb_Key3
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Description4
    {

        [JsonProperty("Key")]
        public RisingDb_Key3 Key { get; set; }

        [JsonProperty("ParameterIndex")]
        public int ParameterIndex { get; set; }

        [JsonProperty("ParameterCount")]
        public int ParameterCount { get; set; }
    }

    public class RisingDb_Name5
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_VBloodPassiveData
    {

        [JsonProperty("Description")]
        public RisingDb_Description4 Description { get; set; }

        [JsonProperty("Name")]
        public RisingDb_Name5 Name { get; set; }
    }

    public class RisingDb_CanCastModId
    {

        [JsonProperty("Id")]
        public int Id { get; set; }
    }

    public class RisingDb_Knockback
    {

        [JsonProperty("Importance")]
        public int Importance { get; set; }

        [JsonProperty("ApplyStun")]
        public bool ApplyStun { get; set; }

        [JsonProperty("CanCastModId")]
        public RisingDb_CanCastModId CanCastModId { get; set; }
    }

    public class RisingDb_ProximitySpeedModifier
    {

        [JsonProperty("CurveGuid")]
        public int CurveGuid { get; set; }

        [JsonProperty("FlipY")]
        public bool FlipY { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_LastValidPosition
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_CanFly
    {

        [JsonProperty("IsFlying")]
        public bool IsFlying { get; set; }

        [JsonProperty("FlyingHeight")]
        public double FlyingHeight { get; set; }

        [JsonProperty("HeightAboveObstacle")]
        public double HeightAboveObstacle { get; set; }

        [JsonProperty("ProximitySpeedModifier")]
        public RisingDb_ProximitySpeedModifier ProximitySpeedModifier { get; set; }

        [JsonProperty("LastValidPosition")]
        public RisingDb_LastValidPosition LastValidPosition { get; set; }

        [JsonProperty("LastTargetHeight")]
        public double LastTargetHeight { get; set; }

        [JsonProperty("VerticalSpeed")]
        public double VerticalSpeed { get; set; }

        [JsonProperty("VerticalAcceleration")]
        public double VerticalAcceleration { get; set; }
    }

    public class RisingDb_ChangeBloodOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("BloodValue")]
        public double BloodValue { get; set; }

        [JsonProperty("BloodQuality")]
        public double BloodQuality { get; set; }

        [JsonProperty("BloodType")]
        public int BloodType { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }

        [JsonProperty("GainBloodType")]
        public string GainBloodType { get; set; }
    }

    public class RisingDb_Name6
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Description5
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_ManagedMissionInjureDataAsset
    {

        [JsonProperty("Name")]
        public RisingDb_Name6 Name { get; set; }

        [JsonProperty("Description")]
        public RisingDb_Description5 Description { get; set; }

        [JsonProperty("Icon")]
        public string Icon { get; set; }
    }

    public class RisingDb_EventId9
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_CreateGameplayEventOnDeath
    {

        [JsonProperty("EventId")]
        public RisingDb_EventId9 EventId { get; set; }

        [JsonProperty("Target")]
        public string Target { get; set; }
    }

    public class RisingDb_Script_GarlicAreaDebuff_DataShared
    {

        [JsonProperty("IsInArea")]
        public bool IsInArea { get; set; }
    }

    public class RisingDb_Sequence2
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_PhysicsRubble
    {

        [JsonProperty("Sequence")]
        public RisingDb_Sequence2 Sequence { get; set; }

        [JsonProperty("Age")]
        public double Age { get; set; }

        [JsonProperty("Duration")]
        public double Duration { get; set; }

        [JsonProperty("DissolveDuration")]
        public double DissolveDuration { get; set; }

        [JsonProperty("SpawnedSequence")]
        public bool SpawnedSequence { get; set; }
    }

    public class RisingDb_Entity8
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_xyz4
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw4
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_c0
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz4 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw4 zw { get; set; }
    }

    public class RisingDb_xyz5
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw5
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_c1
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz5 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw5 zw { get; set; }
    }

    public class RisingDb_xyz6
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw6
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_c2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz6 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw6 zw { get; set; }
    }

    public class RisingDb_xyz7
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw7
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_c3
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz7 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw7 zw { get; set; }
    }

    public class RisingDb_Matrix
    {

        [JsonProperty("c0")]
        public RisingDb_c0 c0 { get; set; }

        [JsonProperty("c1")]
        public RisingDb_c1 c1 { get; set; }

        [JsonProperty("c2")]
        public RisingDb_c2 c2 { get; set; }

        [JsonProperty("c3")]
        public RisingDb_c3 c3 { get; set; }
    }

    public class RisingDb_EntityMatrixElement
    {

        [JsonProperty("Entity")]
        public RisingDb_Entity8 Entity { get; set; }

        [JsonProperty("Matrix")]
        public RisingDb_Matrix Matrix { get; set; }
    }

    public class RisingDb_AbilityGroupComboState
    {

        [JsonProperty("ComboIndex")]
        public int ComboIndex { get; set; }

        [JsonProperty("ComboLength")]
        public int ComboLength { get; set; }
    }

    public class RisingDb_Name7
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Key4
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Description6
    {

        [JsonProperty("Key")]
        public RisingDb_Key4 Key { get; set; }

        [JsonProperty("ParameterIndex")]
        public int ParameterIndex { get; set; }

        [JsonProperty("ParameterCount")]
        public int ParameterCount { get; set; }
    }

    public class RisingDb_ManagedItemData
    {

        [JsonProperty("PrefabName")]
        public string PrefabName { get; set; }

        [JsonProperty("Icon")]
        public string Icon { get; set; }

        [JsonProperty("Name")]
        public RisingDb_Name7 Name { get; set; }

        [JsonProperty("Description")]
        public RisingDb_Description6 Description { get; set; }
    }

    public class RisingDb_Entity9
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ItemData
    {

        [JsonProperty("Entity")]
        public RisingDb_Entity9 Entity { get; set; }

        [JsonProperty("ItemTypeGUID")]
        public int ItemTypeGUID { get; set; }

        [JsonProperty("DropItemPrefab")]
        public int DropItemPrefab { get; set; }

        [JsonProperty("MaxStacks")]
        public int MaxStacks { get; set; }

        [JsonProperty("DropItemArc")]
        public int DropItemArc { get; set; }

        [JsonProperty("ItemType")]
        public string ItemType { get; set; }

        [JsonProperty("RemoveOnConsume")]
        public bool RemoveOnConsume { get; set; }

        [JsonProperty("ItemCategory")]
        public string ItemCategory { get; set; }

        [JsonProperty("SilverValue")]
        public double SilverValue { get; set; }

        [JsonProperty("SoulBound")]
        public bool SoulBound { get; set; }

        [JsonProperty("BloodBound")]
        public bool BloodBound { get; set; }
    }

    public class RisingDb_Salvageable
    {

        [JsonProperty("RecipeGUID")]
        public int RecipeGUID { get; set; }

        [JsonProperty("SalvageFactor")]
        public double SalvageFactor { get; set; }

        [JsonProperty("SalvageTimer")]
        public double SalvageTimer { get; set; }
    }

    public class RisingDb_CastAbilityOnConsume
    {

        [JsonProperty("AbilityGuid")]
        public int AbilityGuid { get; set; }
    }

    public class RisingDb_RecipeRequirementBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }

        [JsonProperty("Stacks")]
        public int Stacks { get; set; }
    }

    public class RisingDb_RequiredProgressionToConsume
    {

        [JsonProperty("RequirementGuid")]
        public int RequirementGuid { get; set; }
    }

    public class RisingDb_ProgressionBookRecipeElement
    {

        [JsonProperty("Recipe")]
        public int Recipe { get; set; }
    }

    public class RisingDb_ProgressionBookTechElement
    {

        [JsonProperty("Tech")]
        public int Tech { get; set; }
    }

    public class RisingDb_ProgressionBookBlueprintElement
    {

        [JsonProperty("Blueprint")]
        public int Blueprint { get; set; }
    }

    public class RisingDb_StartPosition4
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_EndPosition3
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Projectile
    {

        [JsonProperty("Range")]
        public double Range { get; set; }

        [JsonProperty("Speed")]
        public double Speed { get; set; }

        [JsonProperty("TravelToMouseCursor")]
        public bool TravelToMouseCursor { get; set; }

        [JsonProperty("TravelToMouseCursorLengthOffset")]
        public double TravelToMouseCursorLengthOffset { get; set; }

        [JsonProperty("StartPosition")]
        public RisingDb_StartPosition4 StartPosition { get; set; }

        [JsonProperty("EndPosition")]
        public RisingDb_EndPosition3 EndPosition { get; set; }

        [JsonProperty("MinRange")]
        public double MinRange { get; set; }

        [JsonProperty("RecalculateLifetimeBasedOnTarget")]
        public bool RecalculateLifetimeBasedOnTarget { get; set; }
    }

    public class RisingDb_ImmaterialSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id24
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ImmaterialSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id24 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_ImmaterialModificationId
    {

        [JsonProperty("Id")]
        public int Id { get; set; }
    }

    public class RisingDb_Script_Siphon_Blood_Buff_DataShared
    {

        [JsonProperty("IsRevive")]
        public bool IsRevive { get; set; }

        [JsonProperty("ShowAbortText")]
        public bool ShowAbortText { get; set; }

        [JsonProperty("ImmaterialSequence")]
        public RisingDb_ImmaterialSequence ImmaterialSequence { get; set; }

        [JsonProperty("ImmaterialSequenceState")]
        public RisingDb_ImmaterialSequenceState ImmaterialSequenceState { get; set; }

        [JsonProperty("ImmaterialDuration")]
        public double ImmaterialDuration { get; set; }

        [JsonProperty("ImmaterialModificationId")]
        public RisingDb_ImmaterialModificationId ImmaterialModificationId { get; set; }

        [JsonProperty("ImmaterialActive")]
        public bool ImmaterialActive { get; set; }
    }

    public class RisingDb_HideHUDModificationId
    {

        [JsonProperty("Id")]
        public int Id { get; set; }
    }

    public class RisingDb_Script_Siphon_Blood_Buff_DataClient
    {

        [JsonProperty("HideHUDModificationId")]
        public RisingDb_HideHUDModificationId HideHUDModificationId { get; set; }
    }

    public class RisingDb_EventId10
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_CreateGameplayEventsOnTimePassed
    {

        [JsonProperty("EventId")]
        public RisingDb_EventId10 EventId { get; set; }

        [JsonProperty("Target")]
        public string Target { get; set; }

        [JsonProperty("Duration")]
        public double Duration { get; set; }

        [JsonProperty("Time")]
        public double Time { get; set; }
    }

    public class RisingDb_ForceCastOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("ForceCastAbility")]
        public int ForceCastAbility { get; set; }

        [JsonProperty("Target")]
        public string Target { get; set; }
    }

    public class RisingDb_VisionModificationId
    {

        [JsonProperty("Id")]
        public int Id { get; set; }
    }

    public class RisingDb_Script_SetFlyingHeightVision_Buff_DataShared
    {

        [JsonProperty("VisionModificationId")]
        public RisingDb_VisionModificationId VisionModificationId { get; set; }

        [JsonProperty("Delay")]
        public double Delay { get; set; }

        [JsonProperty("BuffActive")]
        public bool BuffActive { get; set; }
    }

    public class RisingDb_PositionOffset
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Script_Buff_GrabToOwner_DataServer
    {

        [JsonProperty("PositionOffset")]
        public RisingDb_PositionOffset PositionOffset { get; set; }

        [JsonProperty("Offset")]
        public double Offset { get; set; }
    }

    public class RisingDb_SalvageEventId
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_ImpactDefaultSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_ScreenshakeSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Script_SalvageOnGameplayEventData
    {

        [JsonProperty("SalvageEventId")]
        public RisingDb_SalvageEventId SalvageEventId { get; set; }

        [JsonProperty("ImpactMapping")]
        public int ImpactMapping { get; set; }

        [JsonProperty("ImpactDefaultSequence")]
        public RisingDb_ImpactDefaultSequence ImpactDefaultSequence { get; set; }

        [JsonProperty("ScreenshakeSequence")]
        public RisingDb_ScreenshakeSequence ScreenshakeSequence { get; set; }
    }

    public class RisingDb_EventId11
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_Filter
    {

        [JsonProperty("TeamFilter")]
        public string TeamFilter { get; set; }

        [JsonProperty("SpellFilter")]
        public string SpellFilter { get; set; }
    }

    public class RisingDb_CreateGameplayEventsOnDirectionalShieldTrigger
    {

        [JsonProperty("EventId")]
        public RisingDb_EventId11 EventId { get; set; }

        [JsonProperty("Filter")]
        public RisingDb_Filter Filter { get; set; }

        [JsonProperty("DestroySpell")]
        public bool DestroySpell { get; set; }
    }

    public class RisingDb_SummonCastleSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_FailSummonCastleSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id25
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_SpellSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id25 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Id26
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_SpellSequenceState2
    {

        [JsonProperty("Id")]
        public RisingDb_Id26 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_CastleAlreadyClaimedKey
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_NotCloseEnoughKey
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_CastleAlreadySummonedKey
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Script_Summon_Castle_DataShared
    {

        [JsonProperty("GlobalCastleManagerPrefab")]
        public int GlobalCastleManagerPrefab { get; set; }

        [JsonProperty("PlacementCheckPrefab")]
        public int PlacementCheckPrefab { get; set; }

        [JsonProperty("InputType")]
        public int InputType { get; set; }

        [JsonProperty("SummonCastleSequence")]
        public RisingDb_SummonCastleSequence SummonCastleSequence { get; set; }

        [JsonProperty("FailSummonCastleSequence")]
        public RisingDb_FailSummonCastleSequence FailSummonCastleSequence { get; set; }

        [JsonProperty("SpellSequenceState")]
        public RisingDb_SpellSequenceState SpellSequenceState { get; set; }

        [JsonProperty("SpellSequenceState2")]
        public RisingDb_SpellSequenceState2 SpellSequenceState2 { get; set; }

        [JsonProperty("CastleAlreadyClaimedKey")]
        public RisingDb_CastleAlreadyClaimedKey CastleAlreadyClaimedKey { get; set; }

        [JsonProperty("NotCloseEnoughKey")]
        public RisingDb_NotCloseEnoughKey NotCloseEnoughKey { get; set; }

        [JsonProperty("CastleAlreadySummonedKey")]
        public RisingDb_CastleAlreadySummonedKey CastleAlreadySummonedKey { get; set; }

        [JsonProperty("SummonCastleSuccess")]
        public bool SummonCastleSuccess { get; set; }
    }

    public class RisingDb_Script_ToggleNearbyArmorRacks_DataShared
    {

        [JsonProperty("Activate")]
        public bool Activate { get; set; }

        [JsonProperty("Radius")]
        public double Radius { get; set; }
    }

    public class RisingDb_WeaponRunCycleModificationId
    {

        [JsonProperty("Id")]
        public int Id { get; set; }
    }

    public class RisingDb_Script_SetWeaponRunCycle_DataClient
    {

        [JsonProperty("WeaponType")]
        public string WeaponType { get; set; }

        [JsonProperty("WeaponRunCycleModificationId")]
        public RisingDb_WeaponRunCycleModificationId WeaponRunCycleModificationId { get; set; }
    }

    public class RisingDb_RingSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id27
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_RingSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id27 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_GameplayEventId2
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_RingAoE_DataShared
    {

        [JsonProperty("RingSequence")]
        public RisingDb_RingSequence RingSequence { get; set; }

        [JsonProperty("RingSequenceState")]
        public RisingDb_RingSequenceState RingSequenceState { get; set; }

        [JsonProperty("GameplayEventId")]
        public RisingDb_GameplayEventId2 GameplayEventId { get; set; }

        [JsonProperty("HitFilter")]
        public string HitFilter { get; set; }

        [JsonProperty("StartRadius")]
        public double StartRadius { get; set; }

        [JsonProperty("EndRadius")]
        public double EndRadius { get; set; }

        [JsonProperty("Duration")]
        public double Duration { get; set; }

        [JsonProperty("RingThickness")]
        public double RingThickness { get; set; }

        [JsonProperty("TimeBetweenHits")]
        public double TimeBetweenHits { get; set; }
    }

    public class RisingDb_Script_DamageZone_SingleTarget_Shared
    {

        [JsonProperty("Radius")]
        public double Radius { get; set; }
    }

    public class RisingDb_Value18
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_OnDamageTakenListener
    {

        [JsonProperty("Value")]
        public RisingDb_Value18 Value { get; set; }
    }

    public class RisingDb_Id28
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_WoundedSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id28 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_KnockbackModification
    {

        [JsonProperty("Id")]
        public int Id { get; set; }
    }

    public class RisingDb_Script_Wounded_DataShared
    {

        [JsonProperty("OnDamageTakenListener")]
        public RisingDb_OnDamageTakenListener OnDamageTakenListener { get; set; }

        [JsonProperty("WoundedSequenceState")]
        public RisingDb_WoundedSequenceState WoundedSequenceState { get; set; }

        [JsonProperty("KnockbackModification")]
        public RisingDb_KnockbackModification KnockbackModification { get; set; }

        [JsonProperty("IsWounded")]
        public bool IsWounded { get; set; }
    }

    public class RisingDb_SequenceGuid8
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_MountedAbilityCastSequence_DataServer
    {

        [JsonProperty("SequenceGuid")]
        public RisingDb_SequenceGuid8 SequenceGuid { get; set; }
    }

    public class RisingDb_TrackingSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id29
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_TrackingSequenceInstance
    {

        [JsonProperty("Id")]
        public RisingDb_Id29 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Script_BloodAltar_TrackVBloodUnit_Client
    {

        [JsonProperty("InCombatBuff")]
        public int InCombatBuff { get; set; }

        [JsonProperty("TrackingSequence")]
        public RisingDb_TrackingSequence TrackingSequence { get; set; }

        [JsonProperty("TrackingSequenceInstance")]
        public RisingDb_TrackingSequenceInstance TrackingSequenceInstance { get; set; }

        [JsonProperty("RemoveEffectDistance")]
        public double RemoveEffectDistance { get; set; }
    }

    public class RisingDb_Position2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Script_BloodAltar_TrackVBloodUnit_Shared
    {

        [JsonProperty("Position")]
        public RisingDb_Position2 Position { get; set; }

        [JsonProperty("TrackedUnit")]
        public int TrackedUnit { get; set; }
    }

    public class RisingDb_BoxSize
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_BoxOffset
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Script_Blood_CrimsonBeam_DataShared
    {

        [JsonProperty("HitFilterInt")]
        public int HitFilterInt { get; set; }

        [JsonProperty("BoxSize")]
        public RisingDb_BoxSize BoxSize { get; set; }

        [JsonProperty("BoxOffset")]
        public RisingDb_BoxOffset BoxOffset { get; set; }

        [JsonProperty("TargetFilterConditionId")]
        public int TargetFilterConditionId { get; set; }
    }

    public class RisingDb_Script_Blood_CrimsonBeam_DataClient
    {

        [JsonProperty("TickRate")]
        public double TickRate { get; set; }

        [JsonProperty("LastTickTime")]
        public double LastTickTime { get; set; }
    }

    public class RisingDb_SequenceGuid9
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Script_Blood_CrimsonBeam_HitSequenceElement
    {

        [JsonProperty("SequenceGuid")]
        public RisingDb_SequenceGuid9 SequenceGuid { get; set; }

        [JsonProperty("Ally")]
        public bool Ally { get; set; }
    }

    public class RisingDb_Sequence3
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id30
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Instance2
    {

        [JsonProperty("Id")]
        public RisingDb_Id30 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_TravelBuffSequence
    {

        [JsonProperty("Sequence")]
        public RisingDb_Sequence3 Sequence { get; set; }

        [JsonProperty("Instance")]
        public RisingDb_Instance2 Instance { get; set; }
    }

    public class RisingDb_SilverBuffSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id31
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_SilverBuffSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id31 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Script_SilverDebuff_DataClient
    {

        [JsonProperty("SilverBuffSequence")]
        public RisingDb_SilverBuffSequence SilverBuffSequence { get; set; }

        [JsonProperty("SilverBuffSequenceState")]
        public RisingDb_SilverBuffSequenceState SilverBuffSequenceState { get; set; }
    }

    public class RisingDb_PositionOffset2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Script_Buff_SetBuffTargetPositionToOwner_DataServer
    {

        [JsonProperty("PositionOffset")]
        public RisingDb_PositionOffset2 PositionOffset { get; set; }
    }

    public class RisingDb_SequenceGUID10
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id32
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_SequenceState2
    {

        [JsonProperty("Id")]
        public RisingDb_Id32 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Mount_Travel_DataShared
    {

        [JsonProperty("SequenceGUID")]
        public RisingDb_SequenceGUID10 SequenceGUID { get; set; }

        [JsonProperty("SequenceState")]
        public RisingDb_SequenceState2 SequenceState { get; set; }

        [JsonProperty("AngleToTarget")]
        public double AngleToTarget { get; set; }
    }

    public class RisingDb_Source
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_VampireDownedBuff
    {

        [JsonProperty("Source")]
        public RisingDb_Source Source { get; set; }
    }

    public class RisingDb_GameplayEventId3
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_Script_CreateGameplayEventOnTickAfterDelay_DataServer
    {

        [JsonProperty("Delay")]
        public double Delay { get; set; }

        [JsonProperty("GameplayEventId")]
        public RisingDb_GameplayEventId3 GameplayEventId { get; set; }
    }

    public class RisingDb_ModificationId2
    {

        [JsonProperty("Id")]
        public int Id { get; set; }
    }

    public class RisingDb_ChangeKnockbackResistanceDuringCast
    {

        [JsonProperty("KnockbackResistanceIndex")]
        public int KnockbackResistanceIndex { get; set; }

        [JsonProperty("ModificationId")]
        public RisingDb_ModificationId2 ModificationId { get; set; }
    }

    public class RisingDb_ItemEntity2
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_AbilityGroupConsumeItemOnCast
    {

        [JsonProperty("ConsumableId")]
        public int ConsumableId { get; set; }

        [JsonProperty("ItemEntity")]
        public RisingDb_ItemEntity2 ItemEntity { get; set; }
    }

    public class RisingDb_DebuffEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_LowBloodSequenceGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id33
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_LowBloodSequenceInstance
    {

        [JsonProperty("Id")]
        public RisingDb_Id33 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Blood
    {

        [JsonProperty("Value")]
        public double Value { get; set; }

        [JsonProperty("MaxBlood")]
        public double MaxBlood { get; set; }

        [JsonProperty("Quality")]
        public double Quality { get; set; }

        [JsonProperty("BloodType")]
        public int BloodType { get; set; }

        [JsonProperty("DefaultBloodType")]
        public int DefaultBloodType { get; set; }

        [JsonProperty("LossPerSecond")]
        public double LossPerSecond { get; set; }

        [JsonProperty("StopDrainOnDisconnect")]
        public bool StopDrainOnDisconnect { get; set; }

        [JsonProperty("DebuffPrefab")]
        public int DebuffPrefab { get; set; }

        [JsonProperty("DebuffEntity")]
        public RisingDb_DebuffEntity DebuffEntity { get; set; }

        [JsonProperty("SCTType")]
        public int SCTType { get; set; }

        [JsonProperty("ShowBloodHUD")]
        public bool ShowBloodHUD { get; set; }

        [JsonProperty("LowBloodSequenceGuid")]
        public RisingDb_LowBloodSequenceGuid LowBloodSequenceGuid { get; set; }

        [JsonProperty("LowBloodSequenceInstance")]
        public RisingDb_LowBloodSequenceInstance LowBloodSequenceInstance { get; set; }

        [JsonProperty("LowBloodSequenceStartFactor")]
        public double LowBloodSequenceStartFactor { get; set; }

        [JsonProperty("ShareVBloodAbility")]
        public int ShareVBloodAbility { get; set; }

        [JsonProperty("IgnoreIdleDrain")]
        public bool IgnoreIdleDrain { get; set; }
    }

    public class RisingDb__Entity46
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ArmorHeadgearSlotEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity46 _Entity { get; set; }
    }

    public class RisingDb__Entity47
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ArmorChestSlotEntity2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity47 _Entity { get; set; }
    }

    public class RisingDb__Entity48
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_WeaponSlotEntity2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity48 _Entity { get; set; }
    }

    public class RisingDb__Entity49
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_GrimoireSlotEntity2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity49 _Entity { get; set; }
    }

    public class RisingDb__Entity50
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ArmorFootgearSlotEntity2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity50 _Entity { get; set; }
    }

    public class RisingDb__Entity51
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ArmorLegsSlotEntity2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity51 _Entity { get; set; }
    }

    public class RisingDb__Entity52
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ClothChestSlotEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity52 _Entity { get; set; }
    }

    public class RisingDb__Entity53
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ClothLegsSlotEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity53 _Entity { get; set; }
    }

    public class RisingDb__Entity54
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_CloakSlotEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity54 _Entity { get; set; }
    }

    public class RisingDb__Entity55
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ArmorGlovesSlotEntity2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity55 _Entity { get; set; }
    }

    public class RisingDb_LevelDamageSettings
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_EquippedItemDestroyedSequenceGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_UnarmedBuffInstance
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Equipment
    {

        [JsonProperty("ArmorHeadgearSlotEntity")]
        public RisingDb_ArmorHeadgearSlotEntity ArmorHeadgearSlotEntity { get; set; }

        [JsonProperty("ArmorHeadgearSlotId")]
        public int ArmorHeadgearSlotId { get; set; }

        [JsonProperty("ArmorChestSlotEntity")]
        public RisingDb_ArmorChestSlotEntity2 ArmorChestSlotEntity { get; set; }

        [JsonProperty("ArmorChestSlotId")]
        public int ArmorChestSlotId { get; set; }

        [JsonProperty("WeaponSlotEntity")]
        public RisingDb_WeaponSlotEntity2 WeaponSlotEntity { get; set; }

        [JsonProperty("WeaponSlotId")]
        public int WeaponSlotId { get; set; }

        [JsonProperty("GrimoireSlotEntity")]
        public RisingDb_GrimoireSlotEntity2 GrimoireSlotEntity { get; set; }

        [JsonProperty("GrimoireSlotId")]
        public int GrimoireSlotId { get; set; }

        [JsonProperty("ArmorFootgearSlotEntity")]
        public RisingDb_ArmorFootgearSlotEntity2 ArmorFootgearSlotEntity { get; set; }

        [JsonProperty("ArmorFootgearSlotId")]
        public int ArmorFootgearSlotId { get; set; }

        [JsonProperty("ArmorLegsSlotEntity")]
        public RisingDb_ArmorLegsSlotEntity2 ArmorLegsSlotEntity { get; set; }

        [JsonProperty("ArmorLegsSlotId")]
        public int ArmorLegsSlotId { get; set; }

        [JsonProperty("ClothChestSlotEntity")]
        public RisingDb_ClothChestSlotEntity ClothChestSlotEntity { get; set; }

        [JsonProperty("ClothChestSlotId")]
        public int ClothChestSlotId { get; set; }

        [JsonProperty("ClothLegsSlotEntity")]
        public RisingDb_ClothLegsSlotEntity ClothLegsSlotEntity { get; set; }

        [JsonProperty("ClothLegsSlotId")]
        public int ClothLegsSlotId { get; set; }

        [JsonProperty("CloakSlotEntity")]
        public RisingDb_CloakSlotEntity CloakSlotEntity { get; set; }

        [JsonProperty("CloakSlotId")]
        public int CloakSlotId { get; set; }

        [JsonProperty("ArmorGlovesSlotEntity")]
        public RisingDb_ArmorGlovesSlotEntity2 ArmorGlovesSlotEntity { get; set; }

        [JsonProperty("ArmorGlovesSlotId")]
        public int ArmorGlovesSlotId { get; set; }

        [JsonProperty("WeaponLevel")]
        public double WeaponLevel { get; set; }

        [JsonProperty("ArmorLevel")]
        public double ArmorLevel { get; set; }

        [JsonProperty("SpellLevel")]
        public double SpellLevel { get; set; }

        [JsonProperty("LevelDamageSettings")]
        public RisingDb_LevelDamageSettings LevelDamageSettings { get; set; }

        [JsonProperty("EquippedItemDestroyedSequenceGuid")]
        public RisingDb_EquippedItemDestroyedSequenceGuid EquippedItemDestroyedSequenceGuid { get; set; }

        [JsonProperty("UnarmedBuffPrefab")]
        public int UnarmedBuffPrefab { get; set; }

        [JsonProperty("UnarmedBuffInstance")]
        public RisingDb_UnarmedBuffInstance UnarmedBuffInstance { get; set; }

        [JsonProperty("WeaponRunCycle")]
        public int WeaponRunCycle { get; set; }
    }

    public class RisingDb__Entity56
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_UserEntity2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity56 _Entity { get; set; }
    }

    public class RisingDb_LastValidPosition2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_PlayerCharacter
    {

        [JsonProperty("UserEntity")]
        public RisingDb_UserEntity2 UserEntity { get; set; }

        [JsonProperty("LastValidPosition")]
        public RisingDb_LastValidPosition2 LastValidPosition { get; set; }
    }

    public class RisingDb_MountEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_TurnRatePerSpeedCurve
    {

        [JsonProperty("CurveGuid")]
        public int CurveGuid { get; set; }

        [JsonProperty("FlipY")]
        public bool FlipY { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_FrictionCurve
    {

        [JsonProperty("CurveGuid")]
        public int CurveGuid { get; set; }

        [JsonProperty("FlipY")]
        public bool FlipY { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_Mounter
    {

        [JsonProperty("MountEntity")]
        public RisingDb_MountEntity MountEntity { get; set; }

        [JsonProperty("IsGalopping")]
        public bool IsGalopping { get; set; }

        [JsonProperty("CanDestroyOnCollision")]
        public bool CanDestroyOnCollision { get; set; }

        [JsonProperty("Acceleration")]
        public double Acceleration { get; set; }

        [JsonProperty("Deceleration")]
        public double Deceleration { get; set; }

        [JsonProperty("WalkMaxSpeed")]
        public double WalkMaxSpeed { get; set; }

        [JsonProperty("GallopMaxSpeed")]
        public double GallopMaxSpeed { get; set; }

        [JsonProperty("MaxSpeedReverse")]
        public double MaxSpeedReverse { get; set; }

        [JsonProperty("DegallopSpeedThreshold")]
        public double DegallopSpeedThreshold { get; set; }

        [JsonProperty("DestroyOnCollisionSpeedThreshold")]
        public double DestroyOnCollisionSpeedThreshold { get; set; }

        [JsonProperty("TurnRate")]
        public double TurnRate { get; set; }

        [JsonProperty("MaxAimAngle")]
        public double MaxAimAngle { get; set; }

        [JsonProperty("JumpFromCliffsMaxDot")]
        public double JumpFromCliffsMaxDot { get; set; }

        [JsonProperty("JumpFromCliffsMinVelocity")]
        public double JumpFromCliffsMinVelocity { get; set; }

        [JsonProperty("TurnRatePerSpeedCurve")]
        public RisingDb_TurnRatePerSpeedCurve TurnRatePerSpeedCurve { get; set; }

        [JsonProperty("FrictionCurve")]
        public RisingDb_FrictionCurve FrictionCurve { get; set; }

        [JsonProperty("GallopMaxSpeedMultiplier")]
        public double GallopMaxSpeedMultiplier { get; set; }
    }

    public class RisingDb_ChargeUpSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_ChargeUpSunbeamSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id34
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ChargeUpSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id34 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Id35
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ChargeUpSunbeamSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id35 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_CooldownSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id36
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_CooldownSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id36 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_TakeDamageInSun
    {

        [JsonProperty("Debuff")]
        public int Debuff { get; set; }

        [JsonProperty("ChargeValue")]
        public double ChargeValue { get; set; }

        [JsonProperty("CooldownValue")]
        public double CooldownValue { get; set; }

        [JsonProperty("SunDamageDisabled")]
        public bool SunDamageDisabled { get; set; }

        [JsonProperty("SunChargeUpTime")]
        public double SunChargeUpTime { get; set; }

        [JsonProperty("ImmuneToSun")]
        public bool ImmuneToSun { get; set; }

        [JsonProperty("AlwaysInSun")]
        public bool AlwaysInSun { get; set; }

        [JsonProperty("SunCooldownTime")]
        public double SunCooldownTime { get; set; }

        [JsonProperty("NextTickTime")]
        public double NextTickTime { get; set; }

        [JsonProperty("ChargeUpSequence")]
        public RisingDb_ChargeUpSequence ChargeUpSequence { get; set; }

        [JsonProperty("ChargeUpSunbeamSequence")]
        public RisingDb_ChargeUpSunbeamSequence ChargeUpSunbeamSequence { get; set; }

        [JsonProperty("ChargeUpSequenceState")]
        public RisingDb_ChargeUpSequenceState ChargeUpSequenceState { get; set; }

        [JsonProperty("ChargeUpSunbeamSequenceState")]
        public RisingDb_ChargeUpSunbeamSequenceState ChargeUpSunbeamSequenceState { get; set; }

        [JsonProperty("CooldownSequence")]
        public RisingDb_CooldownSequence CooldownSequence { get; set; }

        [JsonProperty("CooldownSequenceState")]
        public RisingDb_CooldownSequenceState CooldownSequenceState { get; set; }

        [JsonProperty("SunIntensity")]
        public double SunIntensity { get; set; }

        [JsonProperty("IsInSun")]
        public bool IsInSun { get; set; }
    }

    public class RisingDb_Controller
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ControlledBy
    {

        [JsonProperty("Controller")]
        public RisingDb_Controller Controller { get; set; }
    }

    public class RisingDb_Target4
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_PreviousTarget
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_TargetNetworkId
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Generation")]
        public int Generation { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_TargetSequenceGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id37
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_TargetSequence
    {

        [JsonProperty("Id")]
        public RisingDb_Id37 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_Interactor
    {

        [JsonProperty("Radius")]
        public double Radius { get; set; }

        [JsonProperty("MouseAimRadius")]
        public double MouseAimRadius { get; set; }

        [JsonProperty("Target")]
        public RisingDb_Target4 Target { get; set; }

        [JsonProperty("UseInteractAbilityName")]
        public bool UseInteractAbilityName { get; set; }

        [JsonProperty("PreviousTarget")]
        public RisingDb_PreviousTarget PreviousTarget { get; set; }

        [JsonProperty("TargetNetworkId")]
        public RisingDb_TargetNetworkId TargetNetworkId { get; set; }

        [JsonProperty("InteractAbilityGuid")]
        public int InteractAbilityGuid { get; set; }

        [JsonProperty("TargetSequenceGuid")]
        public RisingDb_TargetSequenceGuid TargetSequenceGuid { get; set; }

        [JsonProperty("TargetSequence")]
        public RisingDb_TargetSequence TargetSequence { get; set; }
    }

    public class RisingDb_Entity10
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Position3
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Normal
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_HoverPick
    {

        [JsonProperty("Entity")]
        public RisingDb_Entity10 Entity { get; set; }

        [JsonProperty("Position")]
        public RisingDb_Position3 Position { get; set; }

        [JsonProperty("Normal")]
        public RisingDb_Normal Normal { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }
    }

    public class RisingDb_Entity11
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Position4
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Normal2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_UnitHoverPick
    {

        [JsonProperty("Entity")]
        public RisingDb_Entity11 Entity { get; set; }

        [JsonProperty("Position")]
        public RisingDb_Position4 Position { get; set; }

        [JsonProperty("Normal")]
        public RisingDb_Normal2 Normal { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }
    }

    public class RisingDb_Picker
    {

        [JsonProperty("HoverPick")]
        public RisingDb_HoverPick HoverPick { get; set; }

        [JsonProperty("HasHoverPick")]
        public bool HasHoverPick { get; set; }

        [JsonProperty("UnitHoverPick")]
        public RisingDb_UnitHoverPick UnitHoverPick { get; set; }

        [JsonProperty("HasUnitHoverPick")]
        public bool HasUnitHoverPick { get; set; }
    }

    public class RisingDb_FadeEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_SpawnLocationIcon
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Generation")]
        public int Generation { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_RespawnCharacter
    {

        [JsonProperty("TimeOfReady")]
        public double TimeOfReady { get; set; }

        [JsonProperty("TimeOfDeath")]
        public long TimeOfDeath { get; set; }

        [JsonProperty("MinTimeToRespawn")]
        public double MinTimeToRespawn { get; set; }

        [JsonProperty("SpawnPointIndex")]
        public int SpawnPointIndex { get; set; }

        [JsonProperty("TimeToSpawn")]
        public double TimeToSpawn { get; set; }

        [JsonProperty("FadeEntity")]
        public RisingDb_FadeEntity FadeEntity { get; set; }

        [JsonProperty("SpawnLocationIcon")]
        public RisingDb_SpawnLocationIcon SpawnLocationIcon { get; set; }

        [JsonProperty("IsReadyToRespawn")]
        public bool IsReadyToRespawn { get; set; }

        [JsonProperty("ChoiceHasBeenMade")]
        public bool ChoiceHasBeenMade { get; set; }

        [JsonProperty("IsRespawning")]
        public bool IsRespawning { get; set; }
    }

    public class RisingDb_CustomizationFeatures
    {

        [JsonProperty("GenderIndex")]
        public int GenderIndex { get; set; }

        [JsonProperty("SkintoneIndex")]
        public int SkintoneIndex { get; set; }

        [JsonProperty("FaceIndex")]
        public int FaceIndex { get; set; }

        [JsonProperty("EyeColorIndex")]
        public int EyeColorIndex { get; set; }

        [JsonProperty("HairStyleIndex")]
        public int HairStyleIndex { get; set; }

        [JsonProperty("HairColorIndex")]
        public int HairColorIndex { get; set; }

        [JsonProperty("FeaturesIndex")]
        public int FeaturesIndex { get; set; }

        [JsonProperty("AccessoriesIndex")]
        public int AccessoriesIndex { get; set; }
    }

    public class RisingDb_CurrentGender
    {

        [JsonProperty("GenderIndex")]
        public int GenderIndex { get; set; }
    }

    public class RisingDb_Energy
    {

        [JsonProperty("Value")]
        public double Value { get; set; }

        [JsonProperty("MaxEnergy")]
        public double MaxEnergy { get; set; }

        [JsonProperty("GainPerSecond")]
        public double GainPerSecond { get; set; }

        [JsonProperty("RegainEnergyChance")]
        public double RegainEnergyChance { get; set; }
    }

    public class RisingDb_KeepMountBuffOnAbilityImpair
    {

        [JsonProperty("Value")]
        public bool Value { get; set; }
    }

    public class RisingDb_LifeLeech
    {

        [JsonProperty("PrimaryLeechFactor")]
        public double PrimaryLeechFactor { get; set; }

        [JsonProperty("PhysicalLifeLeechFactor")]
        public double PhysicalLifeLeechFactor { get; set; }

        [JsonProperty("SpellLifeLeechFactor")]
        public double SpellLifeLeechFactor { get; set; }

        [JsonProperty("AffectRecovery")]
        public bool AffectRecovery { get; set; }
    }

    public class RisingDb_CombatMusicListener_Shared
    {

        [JsonProperty("UnitPrefabGuid")]
        public int UnitPrefabGuid { get; set; }

        [JsonProperty("PlayOutro")]
        public bool PlayOutro { get; set; }
    }

    public class RisingDb_LastTranslation2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_JumpFromCliffs
    {

        [JsonProperty("LastTranslation")]
        public RisingDb_LastTranslation2 LastTranslation { get; set; }

        [JsonProperty("JumpDownTravelBuffPrefabGuid")]
        public int JumpDownTravelBuffPrefabGuid { get; set; }

        [JsonProperty("JumpUpBuffPrefabGuid")]
        public int JumpUpBuffPrefabGuid { get; set; }

        [JsonProperty("CheckAgainstMapFlags")]
        public string CheckAgainstMapFlags { get; set; }

        [JsonProperty("IsInJump")]
        public bool IsInJump { get; set; }

        [JsonProperty("AllowJump")]
        public bool AllowJump { get; set; }

        [JsonProperty("BlockJump")]
        public bool BlockJump { get; set; }

        [JsonProperty("MaxDot")]
        public double MaxDot { get; set; }
    }

    public class RisingDb_CharacterVoiceActivity
    {

        [JsonProperty("VOIPUsername")]
        public int VOIPUsername { get; set; }

        [JsonProperty("IsSpeaking")]
        public bool IsSpeaking { get; set; }

        [JsonProperty("TimeSinceUpdate")]
        public double TimeSinceUpdate { get; set; }

        [JsonProperty("IsMuted")]
        public bool IsMuted { get; set; }
    }

    public class RisingDb_HybridEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_HybridModelUser
    {

        [JsonProperty("HybridEntity")]
        public RisingDb_HybridEntity HybridEntity { get; set; }

        [JsonProperty("TimeSinceLastSeen")]
        public double TimeSinceLastSeen { get; set; }
    }

    public class RisingDb_Position5
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_PathRecorderEntry
    {

        [JsonProperty("Position")]
        public RisingDb_Position5 Position { get; set; }
    }

    public class RisingDb_FadeToBlack_Manual
    {

        [JsonProperty("FadeState")]
        public string FadeState { get; set; }

        [JsonProperty("NormalizedValue")]
        public double NormalizedValue { get; set; }

        [JsonProperty("ManualFadeDurationIn")]
        public double ManualFadeDurationIn { get; set; }

        [JsonProperty("ManualFadeDurationOut")]
        public double ManualFadeDurationOut { get; set; }
    }

    public class RisingDb_ProgressionGainXPLevelWisdom
    {

        [JsonProperty("ProgressionGainValueType")]
        public string ProgressionGainValueType { get; set; }

        [JsonProperty("Value")]
        public int Value { get; set; }
    }

    public class RisingDb_ChangeAbilityOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }

        [JsonProperty("Target")]
        public string Target { get; set; }

        [JsonProperty("AbilityGroupId")]
        public int AbilityGroupId { get; set; }

        [JsonProperty("SlotIndex")]
        public int SlotIndex { get; set; }
    }

    public class RisingDb_AimPreviewInstance
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_AbilityCastAimPreview
    {

        [JsonProperty("AimPreviewPrefab")]
        public int AimPreviewPrefab { get; set; }

        [JsonProperty("SpecificAimPreviewTarget")]
        public int SpecificAimPreviewTarget { get; set; }

        [JsonProperty("AimPreviewInstance")]
        public RisingDb_AimPreviewInstance AimPreviewInstance { get; set; }

        [JsonProperty("ShowForNonLocal")]
        public bool ShowForNonLocal { get; set; }
    }

    public class RisingDb__Entity57
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_FeedableInventoryEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity57 _Entity { get; set; }
    }

    public class RisingDb_HealthRegenModifier
    {

        [JsonProperty("Id")]
        public int Id { get; set; }
    }

    public class RisingDb_FeedableInventory
    {

        [JsonProperty("FeedableInventoryEntity")]
        public RisingDb_FeedableInventoryEntity FeedableInventoryEntity { get; set; }

        [JsonProperty("InventoryPrefabGuid")]
        public int InventoryPrefabGuid { get; set; }

        [JsonProperty("RequiredItemType")]
        public int RequiredItemType { get; set; }

        [JsonProperty("IsActive")]
        public bool IsActive { get; set; }

        [JsonProperty("IsFed")]
        public bool IsFed { get; set; }

        [JsonProperty("FeedTime")]
        public double FeedTime { get; set; }

        [JsonProperty("FeedProgressTime")]
        public double FeedProgressTime { get; set; }

        [JsonProperty("DamageTickDuration")]
        public double DamageTickDuration { get; set; }

        [JsonProperty("DamageTickTime")]
        public double DamageTickTime { get; set; }

        [JsonProperty("DamageTickPercentage")]
        public double DamageTickPercentage { get; set; }

        [JsonProperty("HealthRegenModifier")]
        public RisingDb_HealthRegenModifier HealthRegenModifier { get; set; }
    }

    public class RisingDb_Mounter2
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_MaxSpeedRange
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_AccelerationRange
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_RotationSpeedRange
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_Mountable
    {

        [JsonProperty("Mounter")]
        public RisingDb_Mounter2 Mounter { get; set; }

        [JsonProperty("MaxSpeedRange")]
        public RisingDb_MaxSpeedRange MaxSpeedRange { get; set; }

        [JsonProperty("AccelerationRange")]
        public RisingDb_AccelerationRange AccelerationRange { get; set; }

        [JsonProperty("RotationSpeedRange")]
        public RisingDb_RotationSpeedRange RotationSpeedRange { get; set; }

        [JsonProperty("MountBuff")]
        public int MountBuff { get; set; }

        [JsonProperty("MaxSpeed")]
        public double MaxSpeed { get; set; }

        [JsonProperty("Acceleration")]
        public double Acceleration { get; set; }

        [JsonProperty("RotationSpeed")]
        public double RotationSpeed { get; set; }

        [JsonProperty("HasNearbyUsers")]
        public bool HasNearbyUsers { get; set; }
    }

    public class RisingDb_Sequence4
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_BeamSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_SenseCastleKey
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public object Text { get; set; }
    }

    public class RisingDb_Script_BloodKey_SenseCastle_SharedData
    {

        [JsonProperty("TimeCounter")]
        public double TimeCounter { get; set; }

        [JsonProperty("TimeBetweenPulses")]
        public double TimeBetweenPulses { get; set; }

        [JsonProperty("Sequence")]
        public RisingDb_Sequence4 Sequence { get; set; }

        [JsonProperty("BeamSequence")]
        public RisingDb_BeamSequence BeamSequence { get; set; }

        [JsonProperty("SenseCastleKey")]
        public RisingDb_SenseCastleKey SenseCastleKey { get; set; }

        [JsonProperty("ProjectileSpeed")]
        public double ProjectileSpeed { get; set; }

        [JsonProperty("StopSequenceDistance")]
        public double StopSequenceDistance { get; set; }
    }

    public class RisingDb_Key5
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Description7
    {

        [JsonProperty("Key")]
        public RisingDb_Key5 Key { get; set; }

        [JsonProperty("ParameterIndex")]
        public int ParameterIndex { get; set; }

        [JsonProperty("ParameterCount")]
        public int ParameterCount { get; set; }
    }

    public class RisingDb_ManagedDescriptionData
    {

        [JsonProperty("Description")]
        public RisingDb_Description7 Description { get; set; }
    }

    public class RisingDb_Id38
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_BuffSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id38 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_BuffSequence2
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Script_PlaySequenceInSun_DataShared
    {

        [JsonProperty("BuffSequenceState")]
        public RisingDb_BuffSequenceState BuffSequenceState { get; set; }

        [JsonProperty("BuffSequence")]
        public RisingDb_BuffSequence2 BuffSequence { get; set; }
    }

    public class RisingDb_Key6
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_DescriptionId
    {

        [JsonProperty("Key")]
        public RisingDb_Key6 Key { get; set; }

        [JsonProperty("ParameterIndex")]
        public int ParameterIndex { get; set; }

        [JsonProperty("ParameterCount")]
        public int ParameterCount { get; set; }
    }

    public class RisingDb_Description8
    {

        [JsonProperty("DescriptionId")]
        public RisingDb_DescriptionId DescriptionId { get; set; }
    }

    public class RisingDb_SpawnTranslation
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb__Entity58
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_TransformedTileModel
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity58 _Entity { get; set; }
    }

    public class RisingDb_PlaceTilemodelAbility
    {

        [JsonProperty("PrefabGuid")]
        public int PrefabGuid { get; set; }

        [JsonProperty("SpawnTranslation")]
        public RisingDb_SpawnTranslation SpawnTranslation { get; set; }

        [JsonProperty("SpawnTileRotation")]
        public string SpawnTileRotation { get; set; }

        [JsonProperty("TransformedTileModel")]
        public RisingDb_TransformedTileModel TransformedTileModel { get; set; }
    }

    public class RisingDb_CameraEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_CameraUser
    {

        [JsonProperty("CameraEntity")]
        public RisingDb_CameraEntity CameraEntity { get; set; }
    }

    public class RisingDb__Entity59
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ProgressionEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity59 _Entity { get; set; }
    }

    public class RisingDb_ProgressionMapper
    {

        [JsonProperty("ProgressionEntity")]
        public RisingDb_ProgressionEntity ProgressionEntity { get; set; }
    }

    public class RisingDb__Entity60
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Controlled
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity60 _Entity { get; set; }
    }

    public class RisingDb_PreviouslyControlled
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Controller2
    {

        [JsonProperty("Controlled")]
        public RisingDb_Controlled Controlled { get; set; }

        [JsonProperty("PreviouslyControlled")]
        public RisingDb_PreviouslyControlled PreviouslyControlled { get; set; }
    }

    public class RisingDb__Entity61
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Entity12
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity61 _Entity { get; set; }
    }

    public class RisingDb_AchievementOwner
    {

        [JsonProperty("AchievementDataPrefab")]
        public int AchievementDataPrefab { get; set; }

        [JsonProperty("Entity")]
        public RisingDb_Entity12 Entity { get; set; }
    }

    public class RisingDb_UserZoneEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ZoneEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ChunkCoordinate3
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }
    }

    public class RisingDb_TerrainChunk
    {

        [JsonProperty("ChunkCoordinate")]
        public RisingDb_ChunkCoordinate3 ChunkCoordinate { get; set; }

        [JsonProperty("X")]
        public int X { get; set; }

        [JsonProperty("Y")]
        public int Y { get; set; }
    }

    public class RisingDb_CurrentMapZone
    {

        [JsonProperty("UserZoneEntity")]
        public RisingDb_UserZoneEntity UserZoneEntity { get; set; }

        [JsonProperty("ZoneEntity")]
        public RisingDb_ZoneEntity ZoneEntity { get; set; }

        [JsonProperty("WorldZone")]
        public string WorldZone { get; set; }

        [JsonProperty("TerrainChunk")]
        public RisingDb_TerrainChunk TerrainChunk { get; set; }
    }

    public class RisingDb_ClanRole
    {

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public class RisingDb_CryptSelectorNetworkId
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Generation")]
        public int Generation { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_CryptSelection
    {

        [JsonProperty("CryptSelectorNetworkId")]
        public RisingDb_CryptSelectorNetworkId CryptSelectorNetworkId { get; set; }
    }

    public class RisingDb_UserHealth
    {

        [JsonProperty("Value")]
        public double Value { get; set; }

        [JsonProperty("MaxHealth")]
        public double MaxHealth { get; set; }

        [JsonProperty("Recovery")]
        public double Recovery { get; set; }
    }

    public class RisingDb_Shapeshift
    {

        [JsonProperty("IsShapeshifted")]
        public bool IsShapeshifted { get; set; }
    }

    public class RisingDb_LevelUpSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_ProgrssoionLevelToEntityLevelCurve
    {

        [JsonProperty("CurveGuid")]
        public int CurveGuid { get; set; }

        [JsonProperty("FlipY")]
        public bool FlipY { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_UnitLevelDiffXPFactorCurve_HigherLevel
    {

        [JsonProperty("CurveGuid")]
        public int CurveGuid { get; set; }

        [JsonProperty("FlipY")]
        public bool FlipY { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_UnitLevelDiffXPFactorCurve_LowerLevel
    {

        [JsonProperty("CurveGuid")]
        public int CurveGuid { get; set; }

        [JsonProperty("FlipY")]
        public bool FlipY { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_RequiredXPForLevelCurve
    {

        [JsonProperty("CurveGuid")]
        public int CurveGuid { get; set; }

        [JsonProperty("FlipY")]
        public bool FlipY { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_Experience
    {

        [JsonProperty("Value")]
        public int Value { get; set; }

        [JsonProperty("MaxLevel")]
        public int MaxLevel { get; set; }

        [JsonProperty("UnlockedWisdomPoints")]
        public int UnlockedWisdomPoints { get; set; }

        [JsonProperty("SpentProgressionPoints")]
        public int SpentProgressionPoints { get; set; }

        [JsonProperty("ShowHighlight")]
        public bool ShowHighlight { get; set; }

        [JsonProperty("LevelUpSequence")]
        public RisingDb_LevelUpSequence LevelUpSequence { get; set; }

        [JsonProperty("ProgrssoionLevelToEntityLevelCurve")]
        public RisingDb_ProgrssoionLevelToEntityLevelCurve ProgrssoionLevelToEntityLevelCurve { get; set; }

        [JsonProperty("UnitLevelDiffXPFactorCurve_HigherLevel")]
        public RisingDb_UnitLevelDiffXPFactorCurve_HigherLevel UnitLevelDiffXPFactorCurve_HigherLevel { get; set; }

        [JsonProperty("UnitLevelDiffXPFactorCurve_LowerLevel")]
        public RisingDb_UnitLevelDiffXPFactorCurve_LowerLevel UnitLevelDiffXPFactorCurve_LowerLevel { get; set; }

        [JsonProperty("RequiredXPForLevelCurve")]
        public RisingDb_RequiredXPForLevelCurve RequiredXPForLevelCurve { get; set; }

        [JsonProperty("TotalExperienceForMax")]
        public double TotalExperienceForMax { get; set; }

        [JsonProperty("MaxProgressionLevel")]
        public int MaxProgressionLevel { get; set; }
    }

    public class RisingDb__Entity62
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_User
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity62 _Entity { get; set; }
    }

    public class RisingDb_AllyPermission
    {

        [JsonProperty("User")]
        public RisingDb_User User { get; set; }

        [JsonProperty("Permissions")]
        public string Permissions { get; set; }
    }

    public class RisingDb__Entity63
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_WaypointEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity63 _Entity { get; set; }
    }

    public class RisingDb_UnlockedWaypointElement
    {

        [JsonProperty("WaypointEntity")]
        public RisingDb_WaypointEntity WaypointEntity { get; set; }
    }

    public class RisingDb__Entity64
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_RespawnPoint2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity64 _Entity { get; set; }
    }

    public class RisingDb_RespawnPointNetworkId
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Generation")]
        public int Generation { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_RespawnPointOwnerBuffer
    {

        [JsonProperty("RespawnPoint")]
        public RisingDb_RespawnPoint2 RespawnPoint { get; set; }

        [JsonProperty("RespawnPointNetworkId")]
        public RisingDb_RespawnPointNetworkId RespawnPointNetworkId { get; set; }
    }

    public class RisingDb_ChunkCoordinate4
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }
    }

    public class RisingDb_ZoneStartChunk
    {

        [JsonProperty("ChunkCoordinate")]
        public RisingDb_ChunkCoordinate4 ChunkCoordinate { get; set; }

        [JsonProperty("X")]
        public int X { get; set; }

        [JsonProperty("Y")]
        public int Y { get; set; }
    }

    public class RisingDb__Entity65
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_UserZoneEntity2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity65 _Entity { get; set; }
    }

    public class RisingDb_UserMapZoneElement
    {

        [JsonProperty("ZoneType")]
        public string ZoneType { get; set; }

        [JsonProperty("IsChunkInstance")]
        public bool IsChunkInstance { get; set; }

        [JsonProperty("ZoneStartChunk")]
        public RisingDb_ZoneStartChunk ZoneStartChunk { get; set; }

        [JsonProperty("UserZoneEntity")]
        public RisingDb_UserZoneEntity2 UserZoneEntity { get; set; }
    }

    public class RisingDb_DefaultAction
    {

        [JsonProperty("ActionID")]
        public int ActionID { get; set; }
    }

    public class RisingDb_EmoteAbility
    {

        [JsonProperty("EmoteAbilityId")]
        public int EmoteAbilityId { get; set; }
    }

    public class RisingDb_ShapeshiftAbility
    {

        [JsonProperty("ShapeshiftAbilityId")]
        public int ShapeshiftAbilityId { get; set; }
    }

    public class RisingDb__Entity66
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_TargetEntity2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity66 _Entity { get; set; }
    }

    public class RisingDb_TargetNetworkId2
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Generation")]
        public int Generation { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_MapIconTargetEntity
    {

        [JsonProperty("TargetEntity")]
        public RisingDb_TargetEntity2 TargetEntity { get; set; }

        [JsonProperty("TargetNetworkId")]
        public RisingDb_TargetNetworkId2 TargetNetworkId { get; set; }
    }

    public class RisingDb_TilePosition
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }
    }

    public class RisingDb_MapIconPosition
    {

        [JsonProperty("TilePosition")]
        public RisingDb_TilePosition TilePosition { get; set; }
    }

    public class RisingDb_TeamBoundMapIcon
    {

        [JsonProperty("ShowFor")]
        public string ShowFor { get; set; }
    }

    public class RisingDb_DuskSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id39
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_DuskSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id39 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_DawnSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Id40
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_DawnSequenceState
    {

        [JsonProperty("Id")]
        public RisingDb_Id40 Id { get; set; }

        [JsonProperty("IsEmpty")]
        public bool IsEmpty { get; set; }
    }

    public class RisingDb_DataClient
    {

        [JsonProperty("DuskSequence")]
        public RisingDb_DuskSequence DuskSequence { get; set; }

        [JsonProperty("DuskSequenceState")]
        public RisingDb_DuskSequenceState DuskSequenceState { get; set; }

        [JsonProperty("DawnSequence")]
        public RisingDb_DawnSequence DawnSequence { get; set; }

        [JsonProperty("DawnSequenceState")]
        public RisingDb_DawnSequenceState DawnSequenceState { get; set; }

        [JsonProperty("PreviousIsDay")]
        public bool PreviousIsDay { get; set; }
    }

    public class RisingDb_DayTimeSpan
    {

        [JsonProperty("Days")]
        public string Days { get; set; }

        [JsonProperty("StartMonth")]
        public int StartMonth { get; set; }

        [JsonProperty("EndMonth")]
        public int EndMonth { get; set; }

        [JsonProperty("StartHour")]
        public int StartHour { get; set; }

        [JsonProperty("StartMinute")]
        public int StartMinute { get; set; }

        [JsonProperty("EndHour")]
        public int EndHour { get; set; }

        [JsonProperty("EndMinute")]
        public int EndMinute { get; set; }

        [JsonProperty("HasValue")]
        public bool HasValue { get; set; }
    }

    public class RisingDb_GameDateTimeNow
    {

        [JsonProperty("DayOfYear")]
        public int DayOfYear { get; set; }

        [JsonProperty("Day")]
        public int Day { get; set; }

        [JsonProperty("DayOfWeek")]
        public int DayOfWeek { get; set; }

        [JsonProperty("Month")]
        public int Month { get; set; }

        [JsonProperty("Year")]
        public int Year { get; set; }

        [JsonProperty("WeekDay")]
        public string WeekDay { get; set; }

        [JsonProperty("Hour")]
        public int Hour { get; set; }

        [JsonProperty("Minute")]
        public int Minute { get; set; }
    }

    public class RisingDb_DayNightCycle
    {

        [JsonProperty("Time")]
        public double Time { get; set; }

        [JsonProperty("ServerTime")]
        public double ServerTime { get; set; }

        [JsonProperty("DayNightCycleStartTime")]
        public double DayNightCycleStartTime { get; set; }

        [JsonProperty("DayDurationInSeconds")]
        public double DayDurationInSeconds { get; set; }

        [JsonProperty("Cloudiness")]
        public double Cloudiness { get; set; }

        [JsonProperty("CastlePvPEnabled")]
        public bool CastlePvPEnabled { get; set; }

        [JsonProperty("PlayerPvPEnabled")]
        public bool PlayerPvPEnabled { get; set; }

        [JsonProperty("MorningMoodTransitionDurationBeforeSunrise")]
        public double MorningMoodTransitionDurationBeforeSunrise { get; set; }

        [JsonProperty("MorningMoodTransitionDurationAfterSunrise")]
        public double MorningMoodTransitionDurationAfterSunrise { get; set; }

        [JsonProperty("EveningMoodTransitionDurationBeforeSunset")]
        public double EveningMoodTransitionDurationBeforeSunset { get; set; }

        [JsonProperty("EveningMoodTransitionDurationAfterSunset")]
        public double EveningMoodTransitionDurationAfterSunset { get; set; }

        [JsonProperty("MorningShadowTransitionDurationBeforeSunrise")]
        public double MorningShadowTransitionDurationBeforeSunrise { get; set; }

        [JsonProperty("MorningShadowTransitionDurationAfterSunrise")]
        public double MorningShadowTransitionDurationAfterSunrise { get; set; }

        [JsonProperty("EveningShadowTransitionDurationBeforeSunset")]
        public double EveningShadowTransitionDurationBeforeSunset { get; set; }

        [JsonProperty("EveningShadowTransitionDurationAfterSunset")]
        public double EveningShadowTransitionDurationAfterSunset { get; set; }

        [JsonProperty("DurationBeforeSunDamageAfterSunrise")]
        public double DurationBeforeSunDamageAfterSunrise { get; set; }

        [JsonProperty("DayTimeStartInSeconds")]
        public double DayTimeStartInSeconds { get; set; }

        [JsonProperty("DayTimeDurationInSeconds")]
        public double DayTimeDurationInSeconds { get; set; }

        [JsonProperty("NightTimeDurationInSeconds")]
        public double NightTimeDurationInSeconds { get; set; }

        [JsonProperty("BloodMoonFrequency_Min")]
        public int BloodMoonFrequency_Min { get; set; }

        [JsonProperty("BloodMoonFrequency_Max")]
        public int BloodMoonFrequency_Max { get; set; }

        [JsonProperty("BloodMoonBuffBonus")]
        public double BloodMoonBuffBonus { get; set; }

        [JsonProperty("NextBloodMoonDay")]
        public int NextBloodMoonDay { get; set; }

        [JsonProperty("DayTimeSpan")]
        public RisingDb_DayTimeSpan DayTimeSpan { get; set; }

        [JsonProperty("_TimeSpanTicksSinceStart_k__BackingField")]
        public double _TimeSpanTicksSinceStart_k__BackingField { get; set; }

        [JsonProperty("AmbientBiome")]
        public int AmbientBiome { get; set; }

        [JsonProperty("GameDateTimeNow")]
        public RisingDb_GameDateTimeNow GameDateTimeNow { get; set; }

        [JsonProperty("TimeSinceMidnight")]
        public double TimeSinceMidnight { get; set; }

        [JsonProperty("TimeSinceDayStart")]
        public double TimeSinceDayStart { get; set; }

        [JsonProperty("MorningMoodTransitionStart")]
        public double MorningMoodTransitionStart { get; set; }

        [JsonProperty("MorningMoodTransitionEnd")]
        public double MorningMoodTransitionEnd { get; set; }

        [JsonProperty("MorningMoodTransitionDuration")]
        public double MorningMoodTransitionDuration { get; set; }

        [JsonProperty("MorningShadowTransitionStart")]
        public double MorningShadowTransitionStart { get; set; }

        [JsonProperty("MorningShadowTransitionEnd")]
        public double MorningShadowTransitionEnd { get; set; }

        [JsonProperty("MorningShadowTransitionDuration")]
        public double MorningShadowTransitionDuration { get; set; }

        [JsonProperty("EveningMoodTransitionStart")]
        public double EveningMoodTransitionStart { get; set; }

        [JsonProperty("EveningMoodTransitionEnd")]
        public double EveningMoodTransitionEnd { get; set; }

        [JsonProperty("EveningMoodTransitionDuration")]
        public double EveningMoodTransitionDuration { get; set; }

        [JsonProperty("EveningShadowTransitionStart")]
        public double EveningShadowTransitionStart { get; set; }

        [JsonProperty("EveningShadowTransitionEnd")]
        public double EveningShadowTransitionEnd { get; set; }

        [JsonProperty("EveningShadowTransitionDuration")]
        public double EveningShadowTransitionDuration { get; set; }

        [JsonProperty("TimeOfDay")]
        public string TimeOfDay { get; set; }
    }

    public class RisingDb__Entity67
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_AbilityBar
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity67 _Entity { get; set; }
    }

    public class RisingDb__Entity68
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_StateEntity2
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity68 _Entity { get; set; }
    }

    public class RisingDb__Entity69
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_PreviousStateEntity
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity69 _Entity { get; set; }
    }

    public class RisingDb_AbilityGroupSlot
    {

        [JsonProperty("AbilityBar")]
        public RisingDb_AbilityBar AbilityBar { get; set; }

        [JsonProperty("GroupGuid")]
        public int GroupGuid { get; set; }

        [JsonProperty("SlotId")]
        public int SlotId { get; set; }

        [JsonProperty("StateEntity")]
        public RisingDb_StateEntity2 StateEntity { get; set; }

        [JsonProperty("PreviousStateEntity")]
        public RisingDb_PreviousStateEntity PreviousStateEntity { get; set; }

        [JsonProperty("CopyCooldown")]
        public bool CopyCooldown { get; set; }
    }

    public class RisingDb_UnlockedProgressionElement
    {

        [JsonProperty("UnlockedPrefab")]
        public int UnlockedPrefab { get; set; }
    }

    public class RisingDb_UnlockedShapeshiftElement
    {

        [JsonProperty("UnlockedShapeshift")]
        public int UnlockedShapeshift { get; set; }

        [JsonProperty("UserHasRequiredContentFlags")]
        public bool UserHasRequiredContentFlags { get; set; }
    }

    public class RisingDb_UnlockedRecipeElement
    {

        [JsonProperty("UnlockedRecipe")]
        public int UnlockedRecipe { get; set; }

        [JsonProperty("UserHasRequiredContentFlags")]
        public bool UserHasRequiredContentFlags { get; set; }
    }

    public class RisingDb_UnlockedBlueprintElement
    {

        [JsonProperty("UnlockedBlueprint")]
        public int UnlockedBlueprint { get; set; }

        [JsonProperty("UserHasRequiredContentFlags")]
        public bool UserHasRequiredContentFlags { get; set; }
    }

    public class RisingDb_UnlockedAbilityElement
    {

        [JsonProperty("UnlockedAbility")]
        public int UnlockedAbility { get; set; }

        [JsonProperty("Source")]
        public int Source { get; set; }
    }

    public class RisingDb__Entity70
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_EquipTarget
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity70 _Entity { get; set; }
    }

    public class RisingDb_EquipBuff
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Equippable
    {

        [JsonProperty("EquipTarget")]
        public RisingDb_EquipTarget EquipTarget { get; set; }

        [JsonProperty("EquipBuff")]
        public RisingDb_EquipBuff EquipBuff { get; set; }
    }

    public class RisingDb_SCTBrokenText
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_DurabilitySettings
    {
    }

    public class RisingDb_EquippableData
    {

        [JsonProperty("BuffGuid")]
        public int BuffGuid { get; set; }

        [JsonProperty("EquipmentType")]
        public string EquipmentType { get; set; }

        [JsonProperty("WeaponType")]
        public string WeaponType { get; set; }

        [JsonProperty("EquipmentSet")]
        public int EquipmentSet { get; set; }

        [JsonProperty("SCTBrokenText")]
        public RisingDb_SCTBrokenText SCTBrokenText { get; set; }

        [JsonProperty("DurabilitySettings")]
        public RisingDb_DurabilitySettings DurabilitySettings { get; set; }
    }

    public class RisingDb_WeaponLevelSource
    {

        [JsonProperty("Level")]
        public double Level { get; set; }
    }

    public class RisingDb_DealDamageTypeModifiers
    {

        [JsonProperty("MainDamageModifier")]
        public double MainDamageModifier { get; set; }

        [JsonProperty("ResourceDamageModifier")]
        public double ResourceDamageModifier { get; set; }

        [JsonProperty("SiegeDamageModifier")]
        public double SiegeDamageModifier { get; set; }
    }

    public class RisingDb_RepairSequence
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_Durability
    {

        [JsonProperty("Value")]
        public double Value { get; set; }

        [JsonProperty("MaxDurability")]
        public double MaxDurability { get; set; }

        [JsonProperty("RepairRecipe")]
        public int RepairRecipe { get; set; }

        [JsonProperty("LossType")]
        public string LossType { get; set; }

        [JsonProperty("TakeDamageDurabilityLossFactor")]
        public double TakeDamageDurabilityLossFactor { get; set; }

        [JsonProperty("DealDamageTypeModifiers")]
        public RisingDb_DealDamageTypeModifiers DealDamageTypeModifiers { get; set; }

        [JsonProperty("IsBroken")]
        public bool IsBroken { get; set; }

        [JsonProperty("RepairSequence")]
        public RisingDb_RepairSequence RepairSequence { get; set; }

        [JsonProperty("OneLevelFactor")]
        public double OneLevelFactor { get; set; }

        [JsonProperty("TwoLevelFactor")]
        public double TwoLevelFactor { get; set; }

        [JsonProperty("ThreeLevelFactor")]
        public double ThreeLevelFactor { get; set; }
    }

    public class RisingDb_ReplaceAbilityOnSlotWhenMountedBuffElement
    {

        [JsonProperty("AbilitySlotIndex")]
        public int AbilitySlotIndex { get; set; }

        [JsonProperty("NewGroupId")]
        public int NewGroupId { get; set; }

        [JsonProperty("Priority")]
        public int Priority { get; set; }
    }

    public class RisingDb_ClanGuid
    {

        [JsonProperty("_a")]
        public int _a { get; set; }

        [JsonProperty("_b")]
        public int _b { get; set; }

        [JsonProperty("_c")]
        public int _c { get; set; }

        [JsonProperty("_d")]
        public int _d { get; set; }

        [JsonProperty("_e")]
        public int _e { get; set; }

        [JsonProperty("_f")]
        public int _f { get; set; }

        [JsonProperty("_g")]
        public int _g { get; set; }

        [JsonProperty("_h")]
        public int _h { get; set; }

        [JsonProperty("_i")]
        public int _i { get; set; }

        [JsonProperty("_j")]
        public int _j { get; set; }

        [JsonProperty("_k")]
        public int _k { get; set; }
    }

    public class RisingDb_ClanTeam
    {

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Motto")]
        public string Motto { get; set; }

        [JsonProperty("ClanGuid")]
        public RisingDb_ClanGuid ClanGuid { get; set; }

        [JsonProperty("Tjena")]
        public int Tjena { get; set; }
    }

    public class RisingDb_EventId12
    {

        [JsonProperty("GameplayEventType")]
        public string GameplayEventType { get; set; }

        [JsonProperty("EventId")]
        public int EventId { get; set; }
    }

    public class RisingDb_CreateGameplayEventOnLeaveCliff
    {

        [JsonProperty("EventId")]
        public RisingDb_EventId12 EventId { get; set; }
    }

    public class RisingDb_ItemBuilding
    {

        [JsonProperty("BuildingGuid")]
        public int BuildingGuid { get; set; }
    }

    public class RisingDb_FeedPrisoner
    {

        [JsonProperty("RecoverHealth_Min")]
        public double RecoverHealth_Min { get; set; }

        [JsonProperty("RecoverHealth_Max")]
        public double RecoverHealth_Max { get; set; }

        [JsonProperty("RecoverMisery_Min")]
        public double RecoverMisery_Min { get; set; }

        [JsonProperty("RecoverMisery_Max")]
        public double RecoverMisery_Max { get; set; }
    }

    public class RisingDb_SpellLevelSource
    {

        [JsonProperty("Level")]
        public double Level { get; set; }
    }

    public class RisingDb_ChunkCoordinate5
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }
    }

    public class RisingDb_ChunkCoord
    {

        [JsonProperty("ChunkCoordinate")]
        public RisingDb_ChunkCoordinate5 ChunkCoordinate { get; set; }

        [JsonProperty("X")]
        public int X { get; set; }

        [JsonProperty("Y")]
        public int Y { get; set; }
    }

    public class RisingDb__Entity71
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_Owner3
    {

        [JsonProperty("_WaitingForSync")]
        public bool _WaitingForSync { get; set; }

        [JsonProperty("_Entity")]
        public RisingDb__Entity71 _Entity { get; set; }
    }

    public class RisingDb_CastleIsland
    {

        [JsonProperty("ChunkCoord")]
        public RisingDb_ChunkCoord ChunkCoord { get; set; }

        [JsonProperty("Owner")]
        public RisingDb_Owner3 Owner { get; set; }
    }

    public class RisingDb_SyncedServerDebugSettings
    {

        [JsonProperty("SunDamageDisabled")]
        public bool SunDamageDisabled { get; set; }

        [JsonProperty("DurabilityDisabled")]
        public bool DurabilityDisabled { get; set; }

        [JsonProperty("BloodDrainDisabled")]
        public bool BloodDrainDisabled { get; set; }

        [JsonProperty("CooldownsDisabled")]
        public bool CooldownsDisabled { get; set; }

        [JsonProperty("BuildCostsDisabled")]
        public bool BuildCostsDisabled { get; set; }

        [JsonProperty("TutorialPopupsDisabled")]
        public bool TutorialPopupsDisabled { get; set; }

        [JsonProperty("AllProgressionUnlocked")]
        public bool AllProgressionUnlocked { get; set; }

        [JsonProperty("PlayersInvulnerabilityEnabled")]
        public bool PlayersInvulnerabilityEnabled { get; set; }

        [JsonProperty("DayNightCycleDisabled")]
        public bool DayNightCycleDisabled { get; set; }

        [JsonProperty("NPCsDisabled")]
        public bool NPCsDisabled { get; set; }

        [JsonProperty("BuildingAreaRestrictionDisabled")]
        public bool BuildingAreaRestrictionDisabled { get; set; }

        [JsonProperty("BuildingPlacementRestrictionsDisabled")]
        public bool BuildingPlacementRestrictionsDisabled { get; set; }

        [JsonProperty("FreeBuildingPlacementEnabled")]
        public bool FreeBuildingPlacementEnabled { get; set; }

        [JsonProperty("BuildingReplacementDisabled")]
        public bool BuildingReplacementDisabled { get; set; }

        [JsonProperty("BuildingFloorTerritoryDisabled")]
        public bool BuildingFloorTerritoryDisabled { get; set; }

        [JsonProperty("BuildingEnableDebugging")]
        public bool BuildingEnableDebugging { get; set; }

        [JsonProperty("AllWaypointsUnlocked")]
        public bool AllWaypointsUnlocked { get; set; }

        [JsonProperty("AggroDisabled")]
        public bool AggroDisabled { get; set; }

        [JsonProperty("DropsDisabled")]
        public bool DropsDisabled { get; set; }

        [JsonProperty("Use3DHeight")]
        public bool Use3DHeight { get; set; }

        [JsonProperty("TileCollisionDisabled")]
        public bool TileCollisionDisabled { get; set; }

        [JsonProperty("DynamicCollisionDisabled")]
        public bool DynamicCollisionDisabled { get; set; }

        [JsonProperty("DynamicCloudsDisabled")]
        public bool DynamicCloudsDisabled { get; set; }

        [JsonProperty("HitEffectsDisabled")]
        public bool HitEffectsDisabled { get; set; }

        [JsonProperty("HighCastleRoofsEnabled")]
        public bool HighCastleRoofsEnabled { get; set; }

        [JsonProperty("LinnCastleRoofsEnabled")]
        public bool LinnCastleRoofsEnabled { get; set; }

        [JsonProperty("FeedWoundedRequirementDisabled")]
        public bool FeedWoundedRequirementDisabled { get; set; }

        [JsonProperty("UseSunblockerChecksForFly")]
        public bool UseSunblockerChecksForFly { get; set; }

        [JsonProperty("CastleLimitsDisabled")]
        public bool CastleLimitsDisabled { get; set; }

        [JsonProperty("UseDeathSequencesInsteadOfRagdolls")]
        public bool UseDeathSequencesInsteadOfRagdolls { get; set; }

        [JsonProperty("DisableDebugEvents")]
        public bool DisableDebugEvents { get; set; }

        [JsonProperty("AdminOnlyDebugEvents")]
        public bool AdminOnlyDebugEvents { get; set; }

        [JsonProperty("EveryoneIsAdmin")]
        public bool EveryoneIsAdmin { get; set; }

        [JsonProperty("CastleHeartBloodEssenceDisabled")]
        public bool CastleHeartBloodEssenceDisabled { get; set; }

        [JsonProperty("_Initialized")]
        public bool _Initialized { get; set; }
    }

    public class RisingDb_SpawnLocationSelector
    {

        [JsonProperty("LocationType")]
        public string LocationType { get; set; }
    }

    public class RisingDb_PlayerMapIcon
    {

        [JsonProperty("UserName")]
        public string UserName { get; set; }
    }

    public class RisingDb_AchievementInProgressElement
    {

        [JsonProperty("AchievementPrefabGuid")]
        public int AchievementPrefabGuid { get; set; }

        [JsonProperty("CompletedAmount")]
        public int CompletedAmount { get; set; }
    }

    public class RisingDb_AchievementClaimedElement
    {

        [JsonProperty("AchievementPrefabGuid")]
        public int AchievementPrefabGuid { get; set; }
    }

    public class RisingDb_ServerDebugViewData
    {

        [JsonProperty("HasData")]
        public bool HasData { get; set; }

        [JsonProperty("FrameCounter")]
        public int FrameCounter { get; set; }

        [JsonProperty("Fps")]
        public int Fps { get; set; }

        [JsonProperty("FrameTimeMs")]
        public double FrameTimeMs { get; set; }

        [JsonProperty("EntitiesEnabled")]
        public int EntitiesEnabled { get; set; }

        [JsonProperty("EntitiesDisabled")]
        public int EntitiesDisabled { get; set; }

        [JsonProperty("NetworkedEntities")]
        public int NetworkedEntities { get; set; }

        [JsonProperty("NetworkStatsTime")]
        public double NetworkStatsTime { get; set; }

        [JsonProperty("BytesSentPerSecond")]
        public int BytesSentPerSecond { get; set; }

        [JsonProperty("BytesReceivedPerSecond")]
        public int BytesReceivedPerSecond { get; set; }

        [JsonProperty("MessagesMaxBytesSentPerSecond")]
        public int MessagesMaxBytesSentPerSecond { get; set; }

        [JsonProperty("MessagesMaxBytesReceivedPerSecond")]
        public int MessagesMaxBytesReceivedPerSecond { get; set; }

        [JsonProperty("MessagesSentPerSecond")]
        public int MessagesSentPerSecond { get; set; }

        [JsonProperty("MessagesReceivedPerSecond")]
        public int MessagesReceivedPerSecond { get; set; }

        [JsonProperty("PacketsSentPerSecond")]
        public int PacketsSentPerSecond { get; set; }

        [JsonProperty("PacketsReceivedPerSecond")]
        public int PacketsReceivedPerSecond { get; set; }

        [JsonProperty("AiEnabledCount")]
        public int AiEnabledCount { get; set; }

        [JsonProperty("AiHighPriorityCount")]
        public int AiHighPriorityCount { get; set; }
    }

    public class RisingDb_TargetNetworkId3
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Generation")]
        public int Generation { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_WaypointMapIcon
    {

        [JsonProperty("TargetNetworkId")]
        public RisingDb_TargetNetworkId3 TargetNetworkId { get; set; }

        [JsonProperty("Unlocked")]
        public bool Unlocked { get; set; }
    }

    public class RisingDb_AbilityRemoveBuffCategoryOnStartCast
    {

        [JsonProperty("BuffCategory")]
        public string BuffCategory { get; set; }
    }

    public class RisingDb_CastleClaimRequirementBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }

        [JsonProperty("Stacks")]
        public int Stacks { get; set; }
    }

    public class RisingDb_Name8
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Key7
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Description9
    {

        [JsonProperty("Key")]
        public RisingDb_Key7 Key { get; set; }

        [JsonProperty("ParameterIndex")]
        public int ParameterIndex { get; set; }

        [JsonProperty("ParameterCount")]
        public int ParameterCount { get; set; }
    }

    public class RisingDb_ManagedPerkData
    {

        [JsonProperty("Name")]
        public RisingDb_Name8 Name { get; set; }

        [JsonProperty("Description")]
        public RisingDb_Description9 Description { get; set; }

        [JsonProperty("Icon")]
        public string Icon { get; set; }

        [JsonProperty("Value")]
        public int Value { get; set; }

        [JsonProperty("LootValue")]
        public double LootValue { get; set; }

        [JsonProperty("ID")]
        public int ID { get; set; }
    }

    public class RisingDb_PerkData
    {

        [JsonProperty("PrefabGUID")]
        public int PrefabGUID { get; set; }

        [JsonProperty("PowerValue")]
        public int PowerValue { get; set; }

        [JsonProperty("LootValue")]
        public double LootValue { get; set; }
    }

    public class RisingDb_CastleDestroyRequirementBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }

        [JsonProperty("Stacks")]
        public int Stacks { get; set; }
    }

    public class RisingDb_Quest
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Flavor
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_OverrideRewardText
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_ManagedAchievementData
    {

        [JsonProperty("Quest")]
        public RisingDb_Quest Quest { get; set; }

        [JsonProperty("Flavor")]
        public RisingDb_Flavor Flavor { get; set; }

        [JsonProperty("OverrideRewardText")]
        public RisingDb_OverrideRewardText OverrideRewardText { get; set; }
    }

    public class RisingDb_AchievementData
    {

        [JsonProperty("Reward")]
        public int Reward { get; set; }

        [JsonProperty("Dependency")]
        public int Dependency { get; set; }
    }

    public class RisingDb_AchievementSubTaskEntry
    {

        [JsonProperty("PrefabGuid")]
        public int PrefabGuid { get; set; }
    }

    public class RisingDb_ManualDirection
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_RagdollSourceSetting
    {

        [JsonProperty("Force")]
        public double Force { get; set; }

        [JsonProperty("InheritDirection")]
        public bool InheritDirection { get; set; }

        [JsonProperty("InheritDirectionWeight")]
        public double InheritDirectionWeight { get; set; }

        [JsonProperty("AwayFromSource")]
        public bool AwayFromSource { get; set; }

        [JsonProperty("AwayFromSourceWeight")]
        public double AwayFromSourceWeight { get; set; }

        [JsonProperty("TowardsSource")]
        public bool TowardsSource { get; set; }

        [JsonProperty("TowardsSourceWeight")]
        public double TowardsSourceWeight { get; set; }

        [JsonProperty("UseManualDirection")]
        public bool UseManualDirection { get; set; }

        [JsonProperty("ManualDirection")]
        public RisingDb_ManualDirection ManualDirection { get; set; }

        [JsonProperty("ManualDirectionWeight")]
        public double ManualDirectionWeight { get; set; }
    }

    public class RisingDb_EquipmentSetElement
    {

        [JsonProperty("RequiredItemsInSet")]
        public int RequiredItemsInSet { get; set; }

        [JsonProperty("Buff")]
        public int Buff { get; set; }
    }

    public class RisingDb_SetName
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_EquipmentSet
    {

        [JsonProperty("SetName")]
        public RisingDb_SetName SetName { get; set; }

        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Item")]
        public int Item { get; set; }
    }

    public class RisingDb_Script_WerewolfChieftain_ToggleGates_DataShared
    {

        [JsonProperty("MakeActivate")]
        public bool MakeActivate { get; set; }

        [JsonProperty("Radius")]
        public double Radius { get; set; }

        [JsonProperty("MinionSpawner")]
        public int MinionSpawner { get; set; }
    }

    public class RisingDb_RepairTarget
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_RepairAbility
    {

        [JsonProperty("RepairTarget")]
        public RisingDb_RepairTarget RepairTarget { get; set; }
    }

    public class RisingDb_TextKey
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_ManagedJournalTooltip
    {

        [JsonProperty("TextKey")]
        public RisingDb_TextKey TextKey { get; set; }

        [JsonProperty("Sprite")]
        public string Sprite { get; set; }

        [JsonProperty("SortOrder")]
        public int SortOrder { get; set; }
    }

    public class RisingDb_Entity13
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_RecipeData
    {

        [JsonProperty("Entity")]
        public RisingDb_Entity13 Entity { get; set; }

        [JsonProperty("Guid")]
        public int Guid { get; set; }

        [JsonProperty("CraftDuration")]
        public double CraftDuration { get; set; }

        [JsonProperty("HudSortingOrder")]
        public int HudSortingOrder { get; set; }

        [JsonProperty("AlwaysUnlocked")]
        public bool AlwaysUnlocked { get; set; }

        [JsonProperty("IgnoreServerSettings")]
        public bool IgnoreServerSettings { get; set; }
    }

    public class RisingDb_RecipeOutputBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }

        [JsonProperty("Stacks")]
        public int Stacks { get; set; }
    }

    public class RisingDb_RecipeOutputUnitBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }

        [JsonProperty("Stacks")]
        public int Stacks { get; set; }
    }

    public class RisingDb_VBloodItemSource
    {

        [JsonProperty("VBloodUnit")]
        public int VBloodUnit { get; set; }
    }

    public class RisingDb_Sequence5
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_ImpactMaterialMappingBuffer
    {

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Sequence")]
        public RisingDb_Sequence5 Sequence { get; set; }
    }

    public class RisingDb_UpgradeRequirementBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }

        [JsonProperty("Stacks")]
        public int Stacks { get; set; }
    }

    public class RisingDb_Name9
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_ManagedDataDropGroup
    {

        [JsonProperty("Icon")]
        public string Icon { get; set; }

        [JsonProperty("Name")]
        public RisingDb_Name9 Name { get; set; }
    }

    public class RisingDb_Entity14
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_ItemDataDropGroupBuffer
    {

        [JsonProperty("Entity")]
        public RisingDb_Entity14 Entity { get; set; }

        [JsonProperty("DropItemPrefab")]
        public int DropItemPrefab { get; set; }

        [JsonProperty("Quantity")]
        public int Quantity { get; set; }

        [JsonProperty("Weight")]
        public int Weight { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }
    }

    public class RisingDb_DamageReductionPerTarget
    {

        [JsonProperty("HitResetTimer")]
        public double HitResetTimer { get; set; }

        [JsonProperty("ReductionModifier")]
        public double ReductionModifier { get; set; }
    }

    public class RisingDb_ArmorLevelSource
    {

        [JsonProperty("Level")]
        public double Level { get; set; }
    }

    public class RisingDb_StoredBlood
    {

        [JsonProperty("BloodQuality")]
        public double BloodQuality { get; set; }

        [JsonProperty("BloodType")]
        public int BloodType { get; set; }
    }

    public class RisingDb_EntityCategory2
    {

        [JsonProperty("MainCategory")]
        public string MainCategory { get; set; }

        [JsonProperty("UnitCategory")]
        public string UnitCategory { get; set; }

        [JsonProperty("StructureCategory")]
        public string StructureCategory { get; set; }

        [JsonProperty("MaterialCategory")]
        public string MaterialCategory { get; set; }

        [JsonProperty("ResourceLevel")]
        public int ResourceLevel { get; set; }
    }

    public class RisingDb_LifeLeechSetting
    {

        [JsonProperty("EntityCategory")]
        public RisingDb_EntityCategory2 EntityCategory { get; set; }

        [JsonProperty("Modifier")]
        public double Modifier { get; set; }
    }

    public class RisingDb_ServerDebugLogs
    {

        [JsonProperty("LogCount")]
        public int LogCount { get; set; }

        [JsonProperty("WarningCount")]
        public int WarningCount { get; set; }

        [JsonProperty("ErrorCount")]
        public int ErrorCount { get; set; }

        [JsonProperty("ExceptionCount")]
        public int ExceptionCount { get; set; }
    }

    public class RisingDb_Name10
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Description10
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_ManagedMissionData
    {

        [JsonProperty("Name")]
        public RisingDb_Name10 Name { get; set; }

        [JsonProperty("Description")]
        public RisingDb_Description10 Description { get; set; }

        [JsonProperty("Icon")]
        public string Icon { get; set; }
    }

    public class RisingDb_MissionData
    {

        [JsonProperty("PrefabGUID")]
        public int PrefabGUID { get; set; }

        [JsonProperty("MissionDifficulty")]
        public int MissionDifficulty { get; set; }

        [JsonProperty("ServantSlots")]
        public int ServantSlots { get; set; }

        [JsonProperty("AlwaysUnlocked")]
        public bool AlwaysUnlocked { get; set; }
    }

    public class RisingDb_LifeLeechOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }

        [JsonProperty("Factor")]
        public double Factor { get; set; }

        [JsonProperty("LifeLeechSettingsGuid")]
        public int LifeLeechSettingsGuid { get; set; }
    }

    public class RisingDb_DayTimeSpan2
    {

        [JsonProperty("Days")]
        public string Days { get; set; }

        [JsonProperty("StartMonth")]
        public int StartMonth { get; set; }

        [JsonProperty("EndMonth")]
        public int EndMonth { get; set; }

        [JsonProperty("StartHour")]
        public int StartHour { get; set; }

        [JsonProperty("StartMinute")]
        public int StartMinute { get; set; }

        [JsonProperty("EndHour")]
        public int EndHour { get; set; }

        [JsonProperty("EndMinute")]
        public int EndMinute { get; set; }

        [JsonProperty("HasValue")]
        public bool HasValue { get; set; }
    }

    public class RisingDb_TargetNetworkId4
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Generation")]
        public int Generation { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }
    }

    public class RisingDb_StartGraveyardMapIcon
    {

        [JsonProperty("TargetNetworkId")]
        public RisingDb_TargetNetworkId4 TargetNetworkId { get; set; }
    }

    public class RisingDb_Value19
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }

        [JsonProperty("z")]
        public int z { get; set; }

        [JsonProperty("w")]
        public int w { get; set; }
    }

    public class RisingDb_InvitationReceivedSound
    {

        [JsonProperty("Value")]
        public RisingDb_Value19 Value { get; set; }
    }

    public class RisingDb_Value20
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }

        [JsonProperty("z")]
        public int z { get; set; }

        [JsonProperty("w")]
        public int w { get; set; }
    }

    public class RisingDb_MemberJoinedSound
    {

        [JsonProperty("Value")]
        public RisingDb_Value20 Value { get; set; }
    }

    public class RisingDb_Value21
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }

        [JsonProperty("z")]
        public int z { get; set; }

        [JsonProperty("w")]
        public int w { get; set; }
    }

    public class RisingDb_MemberOnlineSound
    {

        [JsonProperty("Value")]
        public RisingDb_Value21 Value { get; set; }
    }

    public class RisingDb_Value22
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }

        [JsonProperty("z")]
        public int z { get; set; }

        [JsonProperty("w")]
        public int w { get; set; }
    }

    public class RisingDb_MemberLeftSound
    {

        [JsonProperty("Value")]
        public RisingDb_Value22 Value { get; set; }
    }

    public class RisingDb_Value23
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }

        [JsonProperty("z")]
        public int z { get; set; }

        [JsonProperty("w")]
        public int w { get; set; }
    }

    public class RisingDb_Raiding_Attacked
    {

        [JsonProperty("Value")]
        public RisingDb_Value23 Value { get; set; }
    }

    public class RisingDb_Value24
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }

        [JsonProperty("z")]
        public int z { get; set; }

        [JsonProperty("w")]
        public int w { get; set; }
    }

    public class RisingDb_Raiding_Breached
    {

        [JsonProperty("Value")]
        public RisingDb_Value24 Value { get; set; }
    }

    public class RisingDb_Value25
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }

        [JsonProperty("z")]
        public int z { get; set; }

        [JsonProperty("w")]
        public int w { get; set; }
    }

    public class RisingDb_Raiding_GolemSummoned
    {

        [JsonProperty("Value")]
        public RisingDb_Value25 Value { get; set; }
    }

    public class RisingDb_PlayerInviteResultKey_Success
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_PlayerInviteResultKey_NotOnline
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_PlayerInviteResultKey_NoPlayerWithThatName
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_PlayerInviteResultKey_AlreadyInClan
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_PlayerInviteResultKey_AlreadyHasPendingInvite
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_PlayerInviteResultKey_ClanIsFull
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_PlayerInviteResultKey_NoSlotsToInvite
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_PlayerInviteResultKey_CantInviteSelf
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_LeaveClanResultKey_Success
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_LeaveClanResultKey_IsNotInClan
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_LeaveClanResultKey_ClanDoesNotExist
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_AcceptClanInviteResultKey_Success
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_AcceptClanInviteResultKey_NoInvitePresent
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_AcceptClanInviteResultKey_UnknownClan
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_AcceptClanInviteResultKey_IsAlreadyInClan
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_PlayerInviteRequestResponseKey_Accept
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_PlayerInviteRequestResponseKey_Decline
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_PlayerInviteRequestResponseKey_TimeOut
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_ClanInviteReceivedKey
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_MemberOnlineMessage
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_MemberOfflineMessage
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_KickedMessage
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_RoleChangedMessage
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Leader
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Officer
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Member
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_CastleWallBreached
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_NewSiegeWeapon
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_CastleAttacked
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_ClanSystemSettingsComponent
    {

        [JsonProperty("InvitationReceivedSound")]
        public RisingDb_InvitationReceivedSound InvitationReceivedSound { get; set; }

        [JsonProperty("MemberJoinedSound")]
        public RisingDb_MemberJoinedSound MemberJoinedSound { get; set; }

        [JsonProperty("MemberOnlineSound")]
        public RisingDb_MemberOnlineSound MemberOnlineSound { get; set; }

        [JsonProperty("MemberLeftSound")]
        public RisingDb_MemberLeftSound MemberLeftSound { get; set; }

        [JsonProperty("Raiding_Attacked")]
        public RisingDb_Raiding_Attacked Raiding_Attacked { get; set; }

        [JsonProperty("Raiding_Breached")]
        public RisingDb_Raiding_Breached Raiding_Breached { get; set; }

        [JsonProperty("Raiding_GolemSummoned")]
        public RisingDb_Raiding_GolemSummoned Raiding_GolemSummoned { get; set; }

        [JsonProperty("PlayerInviteResultKey_Success")]
        public RisingDb_PlayerInviteResultKey_Success PlayerInviteResultKey_Success { get; set; }

        [JsonProperty("PlayerInviteResultKey_NotOnline")]
        public RisingDb_PlayerInviteResultKey_NotOnline PlayerInviteResultKey_NotOnline { get; set; }

        [JsonProperty("PlayerInviteResultKey_NoPlayerWithThatName")]
        public RisingDb_PlayerInviteResultKey_NoPlayerWithThatName PlayerInviteResultKey_NoPlayerWithThatName { get; set; }

        [JsonProperty("PlayerInviteResultKey_AlreadyInClan")]
        public RisingDb_PlayerInviteResultKey_AlreadyInClan PlayerInviteResultKey_AlreadyInClan { get; set; }

        [JsonProperty("PlayerInviteResultKey_AlreadyHasPendingInvite")]
        public RisingDb_PlayerInviteResultKey_AlreadyHasPendingInvite PlayerInviteResultKey_AlreadyHasPendingInvite { get; set; }

        [JsonProperty("PlayerInviteResultKey_ClanIsFull")]
        public RisingDb_PlayerInviteResultKey_ClanIsFull PlayerInviteResultKey_ClanIsFull { get; set; }

        [JsonProperty("PlayerInviteResultKey_NoSlotsToInvite")]
        public RisingDb_PlayerInviteResultKey_NoSlotsToInvite PlayerInviteResultKey_NoSlotsToInvite { get; set; }

        [JsonProperty("PlayerInviteResultKey_CantInviteSelf")]
        public RisingDb_PlayerInviteResultKey_CantInviteSelf PlayerInviteResultKey_CantInviteSelf { get; set; }

        [JsonProperty("LeaveClanResultKey_Success")]
        public RisingDb_LeaveClanResultKey_Success LeaveClanResultKey_Success { get; set; }

        [JsonProperty("LeaveClanResultKey_IsNotInClan")]
        public RisingDb_LeaveClanResultKey_IsNotInClan LeaveClanResultKey_IsNotInClan { get; set; }

        [JsonProperty("LeaveClanResultKey_ClanDoesNotExist")]
        public RisingDb_LeaveClanResultKey_ClanDoesNotExist LeaveClanResultKey_ClanDoesNotExist { get; set; }

        [JsonProperty("AcceptClanInviteResultKey_Success")]
        public RisingDb_AcceptClanInviteResultKey_Success AcceptClanInviteResultKey_Success { get; set; }

        [JsonProperty("AcceptClanInviteResultKey_NoInvitePresent")]
        public RisingDb_AcceptClanInviteResultKey_NoInvitePresent AcceptClanInviteResultKey_NoInvitePresent { get; set; }

        [JsonProperty("AcceptClanInviteResultKey_UnknownClan")]
        public RisingDb_AcceptClanInviteResultKey_UnknownClan AcceptClanInviteResultKey_UnknownClan { get; set; }

        [JsonProperty("AcceptClanInviteResultKey_IsAlreadyInClan")]
        public RisingDb_AcceptClanInviteResultKey_IsAlreadyInClan AcceptClanInviteResultKey_IsAlreadyInClan { get; set; }

        [JsonProperty("PlayerInviteRequestResponseKey_Accept")]
        public RisingDb_PlayerInviteRequestResponseKey_Accept PlayerInviteRequestResponseKey_Accept { get; set; }

        [JsonProperty("PlayerInviteRequestResponseKey_Decline")]
        public RisingDb_PlayerInviteRequestResponseKey_Decline PlayerInviteRequestResponseKey_Decline { get; set; }

        [JsonProperty("PlayerInviteRequestResponseKey_TimeOut")]
        public RisingDb_PlayerInviteRequestResponseKey_TimeOut PlayerInviteRequestResponseKey_TimeOut { get; set; }

        [JsonProperty("ClanInviteReceivedKey")]
        public RisingDb_ClanInviteReceivedKey ClanInviteReceivedKey { get; set; }

        [JsonProperty("MemberOnlineMessage")]
        public RisingDb_MemberOnlineMessage MemberOnlineMessage { get; set; }

        [JsonProperty("MemberOfflineMessage")]
        public RisingDb_MemberOfflineMessage MemberOfflineMessage { get; set; }

        [JsonProperty("KickedMessage")]
        public RisingDb_KickedMessage KickedMessage { get; set; }

        [JsonProperty("RoleChangedMessage")]
        public RisingDb_RoleChangedMessage RoleChangedMessage { get; set; }

        [JsonProperty("Leader")]
        public RisingDb_Leader Leader { get; set; }

        [JsonProperty("Officer")]
        public RisingDb_Officer Officer { get; set; }

        [JsonProperty("Member")]
        public RisingDb_Member Member { get; set; }

        [JsonProperty("CastleWallBreached")]
        public RisingDb_CastleWallBreached CastleWallBreached { get; set; }

        [JsonProperty("NewSiegeWeapon")]
        public RisingDb_NewSiegeWeapon NewSiegeWeapon { get; set; }

        [JsonProperty("CastleAttacked")]
        public RisingDb_CastleAttacked CastleAttacked { get; set; }
    }

    public class RisingDb_Name11
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_ManagedUnitBloodTypeData
    {

        [JsonProperty("Name")]
        public RisingDb_Name11 Name { get; set; }

        [JsonProperty("Icon")]
        public string Icon { get; set; }

        [JsonProperty("Icon2")]
        public string Icon2 { get; set; }
    }

    public class RisingDb_UnitBloodTypeBuff
    {

        [JsonProperty("MinQuality")]
        public double MinQuality { get; set; }

        [JsonProperty("BuffType")]
        public int BuffType { get; set; }
    }

    public class RisingDb_Entity15
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_DropTableData
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }

        [JsonProperty("Entity")]
        public RisingDb_Entity15 Entity { get; set; }
    }

    public class RisingDb_DropTableDataBuffer
    {

        [JsonProperty("ItemGuid")]
        public int ItemGuid { get; set; }

        [JsonProperty("ItemType")]
        public string ItemType { get; set; }

        [JsonProperty("Quantity")]
        public int Quantity { get; set; }

        [JsonProperty("DropRate")]
        public double DropRate { get; set; }
    }

    public class RisingDb_LKey_PerformanceInfoMessage
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_LKey_ServerIsRestartingMessage
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_LKey_ServerFailedSavingMessage
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_GeneralGameplayCollection
    {

        [JsonProperty("LKey_PerformanceInfoMessage")]
        public RisingDb_LKey_PerformanceInfoMessage LKey_PerformanceInfoMessage { get; set; }

        [JsonProperty("LKey_ServerIsRestartingMessage")]
        public RisingDb_LKey_ServerIsRestartingMessage LKey_ServerIsRestartingMessage { get; set; }

        [JsonProperty("LKey_ServerFailedSavingMessage")]
        public RisingDb_LKey_ServerFailedSavingMessage LKey_ServerFailedSavingMessage { get; set; }
    }

    public class RisingDb_PrefabSetBuffer
    {

        [JsonProperty("PrefabGUID")]
        public int PrefabGUID { get; set; }
    }

    public class RisingDb_PrefabSetSourceObjectBuffer
    {

        [JsonProperty("PrefabGUID")]
        public int PrefabGUID { get; set; }
    }

    public class RisingDb_CharacterCustomizationSettingsComponent
    {

        [JsonProperty("SkintoneColorCount")]
        public int SkintoneColorCount { get; set; }

        [JsonProperty("EyeColorCount")]
        public int EyeColorCount { get; set; }

        [JsonProperty("HairColorCount")]
        public int HairColorCount { get; set; }

        [JsonProperty("MaleFacesCount")]
        public int MaleFacesCount { get; set; }

        [JsonProperty("MaleHairsCount")]
        public int MaleHairsCount { get; set; }

        [JsonProperty("MaleFeaturesCount")]
        public int MaleFeaturesCount { get; set; }

        [JsonProperty("MaleAccessoriesCount")]
        public int MaleAccessoriesCount { get; set; }

        [JsonProperty("FemaleFacesCount")]
        public int FemaleFacesCount { get; set; }

        [JsonProperty("FemaleHairsCount")]
        public int FemaleHairsCount { get; set; }

        [JsonProperty("FemaleFeaturesCount")]
        public int FemaleFeaturesCount { get; set; }

        [JsonProperty("FemaleAccessoriesCount")]
        public int FemaleAccessoriesCount { get; set; }
    }

    public class RisingDb_MaleFacesEntry
    {

        [JsonProperty("Requirement")]
        public string Requirement { get; set; }

        [JsonProperty("RequirementRO")]
        public string RequirementRO { get; set; }
    }

    public class RisingDb_MaleHairsEntry
    {

        [JsonProperty("Requirement")]
        public string Requirement { get; set; }

        [JsonProperty("RequirementRO")]
        public string RequirementRO { get; set; }
    }

    public class RisingDb_MaleFeaturesEntry
    {

        [JsonProperty("Requirement")]
        public string Requirement { get; set; }

        [JsonProperty("RequirementRO")]
        public string RequirementRO { get; set; }
    }

    public class RisingDb_MaleAccessoriesEntry
    {

        [JsonProperty("Requirement")]
        public string Requirement { get; set; }

        [JsonProperty("RequirementRO")]
        public string RequirementRO { get; set; }
    }

    public class RisingDb_FemaleFacesEntry
    {

        [JsonProperty("Requirement")]
        public string Requirement { get; set; }

        [JsonProperty("RequirementRO")]
        public string RequirementRO { get; set; }
    }

    public class RisingDb_FemaleHairsEntry
    {

        [JsonProperty("Requirement")]
        public string Requirement { get; set; }

        [JsonProperty("RequirementRO")]
        public string RequirementRO { get; set; }
    }

    public class RisingDb_FemaleFeaturesEntry
    {

        [JsonProperty("Requirement")]
        public string Requirement { get; set; }

        [JsonProperty("RequirementRO")]
        public string RequirementRO { get; set; }
    }

    public class RisingDb_FemaleAccessoriesEntry
    {

        [JsonProperty("Requirement")]
        public string Requirement { get; set; }

        [JsonProperty("RequirementRO")]
        public string RequirementRO { get; set; }
    }

    public class RisingDb_ToFewPortalUnlocked
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_TeleportBoundItemText
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_HasCharmedUnitText
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_UseWaypoint
    {

        [JsonProperty("ToFewPortalUnlocked")]
        public RisingDb_ToFewPortalUnlocked ToFewPortalUnlocked { get; set; }

        [JsonProperty("TeleportBoundItemText")]
        public RisingDb_TeleportBoundItemText TeleportBoundItemText { get; set; }

        [JsonProperty("HasCharmedUnitText")]
        public RisingDb_HasCharmedUnitText HasCharmedUnitText { get; set; }

        [JsonProperty("TeleportBoundItemSctTypeGuid")]
        public int TeleportBoundItemSctTypeGuid { get; set; }
    }

    public class RisingDb_CastleRoom
    {

        [JsonProperty("IsMissingWalls")]
        public bool IsMissingWalls { get; set; }

        [JsonProperty("HasRoof")]
        public bool HasRoof { get; set; }

        [JsonProperty("IsEnclosedRoom")]
        public bool IsEnclosedRoom { get; set; }
    }

    public class RisingDb_ItemRepairBuffer
    {

        [JsonProperty("Guid")]
        public int Guid { get; set; }

        [JsonProperty("Stacks")]
        public int Stacks { get; set; }
    }

    public class RisingDb_Target5
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_CameraTarget
    {

        [JsonProperty("Target")]
        public RisingDb_Target5 Target { get; set; }
    }

    public class RisingDb_Position6
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_LastTarget
    {

        [JsonProperty("Yaw")]
        public double Yaw { get; set; }

        [JsonProperty("Pitch")]
        public double Pitch { get; set; }

        [JsonProperty("Position")]
        public RisingDb_Position6 Position { get; set; }
    }

    public class RisingDb_Position7
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Target6
    {

        [JsonProperty("Yaw")]
        public double Yaw { get; set; }

        [JsonProperty("Pitch")]
        public double Pitch { get; set; }

        [JsonProperty("Position")]
        public RisingDb_Position7 Position { get; set; }
    }

    public class RisingDb_Position8
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Current
    {

        [JsonProperty("Yaw")]
        public double Yaw { get; set; }

        [JsonProperty("Pitch")]
        public double Pitch { get; set; }

        [JsonProperty("Position")]
        public RisingDb_Position8 Position { get; set; }
    }

    public class RisingDb_FreeCameraState
    {

        [JsonProperty("StaticCamera")]
        public bool StaticCamera { get; set; }

        [JsonProperty("LastTarget")]
        public RisingDb_LastTarget LastTarget { get; set; }

        [JsonProperty("Target")]
        public RisingDb_Target6 Target { get; set; }

        [JsonProperty("Current")]
        public RisingDb_Current Current { get; set; }

        [JsonProperty("MovementSpeed")]
        public double MovementSpeed { get; set; }
    }

    public class RisingDb_Resolution
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_xyz8
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw8
    {

        [JsonProperty("x")]
        public object x { get; set; }

        [JsonProperty("y")]
        public object y { get; set; }
    }

    public class RisingDb_c02
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz8 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw8 zw { get; set; }
    }

    public class RisingDb_xyz9
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw9
    {

        [JsonProperty("x")]
        public object x { get; set; }

        [JsonProperty("y")]
        public object y { get; set; }
    }

    public class RisingDb_c12
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz9 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw9 zw { get; set; }
    }

    public class RisingDb_xyz10
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw10
    {

        [JsonProperty("x")]
        public object x { get; set; }

        [JsonProperty("y")]
        public object y { get; set; }
    }

    public class RisingDb_c22
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz10 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw10 zw { get; set; }
    }

    public class RisingDb_xyz11
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw11
    {

        [JsonProperty("x")]
        public object x { get; set; }

        [JsonProperty("y")]
        public object y { get; set; }
    }

    public class RisingDb_c32
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz11 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw11 zw { get; set; }
    }

    public class RisingDb_ProjectionMatrix
    {

        [JsonProperty("c0")]
        public RisingDb_c02 c0 { get; set; }

        [JsonProperty("c1")]
        public RisingDb_c12 c1 { get; set; }

        [JsonProperty("c2")]
        public RisingDb_c22 c2 { get; set; }

        [JsonProperty("c3")]
        public RisingDb_c32 c3 { get; set; }
    }

    public class RisingDb_Viewport
    {

        [JsonProperty("IsValidViewport")]
        public bool IsValidViewport { get; set; }

        [JsonProperty("FieldOfView")]
        public double FieldOfView { get; set; }

        [JsonProperty("Resolution")]
        public RisingDb_Resolution Resolution { get; set; }

        [JsonProperty("NearClipPlane")]
        public double NearClipPlane { get; set; }

        [JsonProperty("FarClipPlane")]
        public double FarClipPlane { get; set; }

        [JsonProperty("AspectRatio")]
        public double AspectRatio { get; set; }

        [JsonProperty("ProjectionMatrix")]
        public RisingDb_ProjectionMatrix ProjectionMatrix { get; set; }
    }

    public class RisingDb_xyz12
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw12
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_c03
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz12 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw12 zw { get; set; }
    }

    public class RisingDb_xyz13
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw13
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_c13
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz13 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw13 zw { get; set; }
    }

    public class RisingDb_xyz14
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw14
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_c23
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz14 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw14 zw { get; set; }
    }

    public class RisingDb_xyz15
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw15
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_c33
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz15 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw15 zw { get; set; }
    }

    public class RisingDb_ViewMatrix
    {

        [JsonProperty("c0")]
        public RisingDb_c03 c0 { get; set; }

        [JsonProperty("c1")]
        public RisingDb_c13 c1 { get; set; }

        [JsonProperty("c2")]
        public RisingDb_c23 c2 { get; set; }

        [JsonProperty("c3")]
        public RisingDb_c33 c3 { get; set; }
    }

    public class RisingDb_Position9
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_normalized2
    {

        [JsonProperty("x")]
        public object x { get; set; }

        [JsonProperty("y")]
        public object y { get; set; }

        [JsonProperty("z")]
        public object z { get; set; }

        [JsonProperty("normalized")]
        public object normalized { get; set; }

        [JsonProperty("magnitude")]
        public object magnitude { get; set; }

        [JsonProperty("sqrMagnitude")]
        public object sqrMagnitude { get; set; }
    }

    public class RisingDb_normalized
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("normalized")]
        public RisingDb_normalized2 normalized { get; set; }

        [JsonProperty("magnitude")]
        public double magnitude { get; set; }

        [JsonProperty("sqrMagnitude")]
        public double sqrMagnitude { get; set; }
    }

    public class RisingDb_eulerAngles
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("normalized")]
        public RisingDb_normalized normalized { get; set; }

        [JsonProperty("magnitude")]
        public double magnitude { get; set; }

        [JsonProperty("sqrMagnitude")]
        public double sqrMagnitude { get; set; }
    }

    public class RisingDb_Rotation2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("eulerAngles")]
        public RisingDb_eulerAngles eulerAngles { get; set; }
    }

    public class RisingDb_Resolution2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_xyz16
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw16
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_c04
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz16 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw16 zw { get; set; }
    }

    public class RisingDb_xyz17
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw17
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_c14
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz17 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw17 zw { get; set; }
    }

    public class RisingDb_xyz18
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw18
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_c24
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz18 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw18 zw { get; set; }
    }

    public class RisingDb_xyz19
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw19
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_c34
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz19 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw19 zw { get; set; }
    }

    public class RisingDb_ProjectionMatrix2
    {

        [JsonProperty("c0")]
        public RisingDb_c04 c0 { get; set; }

        [JsonProperty("c1")]
        public RisingDb_c14 c1 { get; set; }

        [JsonProperty("c2")]
        public RisingDb_c24 c2 { get; set; }

        [JsonProperty("c3")]
        public RisingDb_c34 c3 { get; set; }
    }

    public class RisingDb_HybridCameraData
    {

        [JsonProperty("Viewport")]
        public RisingDb_Viewport Viewport { get; set; }

        [JsonProperty("ViewMatrix")]
        public RisingDb_ViewMatrix ViewMatrix { get; set; }

        [JsonProperty("Position")]
        public RisingDb_Position9 Position { get; set; }

        [JsonProperty("Rotation")]
        public RisingDb_Rotation2 Rotation { get; set; }

        [JsonProperty("FieldOfView")]
        public double FieldOfView { get; set; }

        [JsonProperty("Resolution")]
        public RisingDb_Resolution2 Resolution { get; set; }

        [JsonProperty("NearClipPlane")]
        public double NearClipPlane { get; set; }

        [JsonProperty("FarClipPlane")]
        public double FarClipPlane { get; set; }

        [JsonProperty("ProjectionMatrix")]
        public RisingDb_ProjectionMatrix2 ProjectionMatrix { get; set; }
    }

    public class RisingDb_xyz20
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_zw20
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }
    }

    public class RisingDb_Plane
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("xyz")]
        public RisingDb_xyz20 xyz { get; set; }

        [JsonProperty("zw")]
        public RisingDb_zw20 zw { get; set; }
    }

    public class RisingDb_HybridCameraFrustumPlane
    {

        [JsonProperty("Plane")]
        public RisingDb_Plane Plane { get; set; }
    }

    public class RisingDb_GlobalCastleManager
    {

        [JsonProperty("CastleIslandPrefab")]
        public int CastleIslandPrefab { get; set; }

        [JsonProperty("CastleTeamPrefab")]
        public int CastleTeamPrefab { get; set; }
    }

    public class RisingDb_BonusKey
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_TextRequirements
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_TextBonus
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_ManagedStationBonusData
    {

        [JsonProperty("BonusType")]
        public string BonusType { get; set; }

        [JsonProperty("ModificationValue")]
        public double ModificationValue { get; set; }

        [JsonProperty("Icon_Unlocked")]
        public string Icon_Unlocked { get; set; }

        [JsonProperty("Icon_Locked")]
        public string Icon_Locked { get; set; }

        [JsonProperty("Icon_Bonus")]
        public string Icon_Bonus { get; set; }

        [JsonProperty("Icon_Unlocked_TextImage")]
        public string Icon_Unlocked_TextImage { get; set; }

        [JsonProperty("Icon_Locked_TextImage")]
        public string Icon_Locked_TextImage { get; set; }

        [JsonProperty("BonusKey")]
        public RisingDb_BonusKey BonusKey { get; set; }

        [JsonProperty("TextRequirements")]
        public RisingDb_TextRequirements TextRequirements { get; set; }

        [JsonProperty("TextBonus")]
        public RisingDb_TextBonus TextBonus { get; set; }
    }

    public class RisingDb_EscapeSequenceGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_SteppedOnSequenceGuid
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }
    }

    public class RisingDb_EscapePosition
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_CritterData
    {

        [JsonProperty("EscapeSequenceGuid")]
        public RisingDb_EscapeSequenceGuid EscapeSequenceGuid { get; set; }

        [JsonProperty("SteppedOnSequenceGuid")]
        public RisingDb_SteppedOnSequenceGuid SteppedOnSequenceGuid { get; set; }

        [JsonProperty("EscapePosition")]
        public RisingDb_EscapePosition EscapePosition { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("Lifetime")]
        public double Lifetime { get; set; }

        [JsonProperty("EscapeSpeed")]
        public double EscapeSpeed { get; set; }

        [JsonProperty("RotationSpeed")]
        public double RotationSpeed { get; set; }

        [JsonProperty("IdleAnimationSpeed")]
        public double IdleAnimationSpeed { get; set; }

        [JsonProperty("OnAggroAnimationSpeed")]
        public double OnAggroAnimationSpeed { get; set; }

        [JsonProperty("EscapeAnimationSpeed")]
        public double EscapeAnimationSpeed { get; set; }

        [JsonProperty("OnAggroDuration")]
        public double OnAggroDuration { get; set; }

        [JsonProperty("TurnToEscapeDuration")]
        public double TurnToEscapeDuration { get; set; }

        [JsonProperty("AdditiveTurnFactor")]
        public double AdditiveTurnFactor { get; set; }

        [JsonProperty("FadeOutTime")]
        public double FadeOutTime { get; set; }

        [JsonProperty("CurrentAggroTime")]
        public double CurrentAggroTime { get; set; }

        [JsonProperty("CurrentAliveTime")]
        public double CurrentAliveTime { get; set; }

        [JsonProperty("CurrentUpAngle")]
        public double CurrentUpAngle { get; set; }

        [JsonProperty("SteppedOnSequenceDuration")]
        public double SteppedOnSequenceDuration { get; set; }

        [JsonProperty("StepCollisionSphereRadiusSq")]
        public double StepCollisionSphereRadiusSq { get; set; }

        [JsonProperty("CanBeSteppedOn")]
        public bool CanBeSteppedOn { get; set; }

        [JsonProperty("EscapesByFlying")]
        public bool EscapesByFlying { get; set; }

        [JsonProperty("IsTame")]
        public bool IsTame { get; set; }
    }

    public class RisingDb_DrivenEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_RagdollDriver
    {

        [JsonProperty("DrivenEntity")]
        public RisingDb_DrivenEntity DrivenEntity { get; set; }

        [JsonProperty("SpawnTime")]
        public double SpawnTime { get; set; }
    }

    public class RisingDb_Value26
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_RagdollBoneEntityElement
    {

        [JsonProperty("Value")]
        public RisingDb_Value26 Value { get; set; }
    }

    public class RisingDb_normalized5
    {

        [JsonProperty("x")]
        public object x { get; set; }

        [JsonProperty("y")]
        public object y { get; set; }

        [JsonProperty("z")]
        public object z { get; set; }

        [JsonProperty("normalized")]
        public object normalized { get; set; }

        [JsonProperty("magnitude")]
        public object magnitude { get; set; }

        [JsonProperty("sqrMagnitude")]
        public object sqrMagnitude { get; set; }
    }

    public class RisingDb_normalized4
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("normalized")]
        public RisingDb_normalized5 normalized { get; set; }

        [JsonProperty("magnitude")]
        public double magnitude { get; set; }

        [JsonProperty("sqrMagnitude")]
        public double sqrMagnitude { get; set; }
    }

    public class RisingDb_normalized3
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("normalized")]
        public RisingDb_normalized4 normalized { get; set; }

        [JsonProperty("magnitude")]
        public double magnitude { get; set; }

        [JsonProperty("sqrMagnitude")]
        public double sqrMagnitude { get; set; }
    }

    public class RisingDb_Position10
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("normalized")]
        public RisingDb_normalized3 normalized { get; set; }

        [JsonProperty("magnitude")]
        public double magnitude { get; set; }

        [JsonProperty("sqrMagnitude")]
        public double sqrMagnitude { get; set; }
    }

    public class RisingDb_normalized7
    {

        [JsonProperty("x")]
        public object x { get; set; }

        [JsonProperty("y")]
        public object y { get; set; }

        [JsonProperty("z")]
        public object z { get; set; }

        [JsonProperty("normalized")]
        public object normalized { get; set; }

        [JsonProperty("magnitude")]
        public object magnitude { get; set; }

        [JsonProperty("sqrMagnitude")]
        public object sqrMagnitude { get; set; }
    }

    public class RisingDb_normalized6
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("normalized")]
        public RisingDb_normalized7 normalized { get; set; }

        [JsonProperty("magnitude")]
        public double magnitude { get; set; }

        [JsonProperty("sqrMagnitude")]
        public double sqrMagnitude { get; set; }
    }

    public class RisingDb_eulerAngles2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("normalized")]
        public RisingDb_normalized6 normalized { get; set; }

        [JsonProperty("magnitude")]
        public double magnitude { get; set; }

        [JsonProperty("sqrMagnitude")]
        public double sqrMagnitude { get; set; }
    }

    public class RisingDb_Rotation3
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }

        [JsonProperty("w")]
        public double w { get; set; }

        [JsonProperty("eulerAngles")]
        public RisingDb_eulerAngles2 eulerAngles { get; set; }
    }

    public class RisingDb_RagdollBoneTransformElement
    {

        [JsonProperty("Position")]
        public RisingDb_Position10 Position { get; set; }

        [JsonProperty("Rotation")]
        public RisingDb_Rotation3 Rotation { get; set; }
    }

    public class RisingDb_TaskTitle
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_EntityCategory3
    {

        [JsonProperty("MainCategory")]
        public string MainCategory { get; set; }

        [JsonProperty("UnitCategory")]
        public string UnitCategory { get; set; }

        [JsonProperty("StructureCategory")]
        public string StructureCategory { get; set; }

        [JsonProperty("MaterialCategory")]
        public string MaterialCategory { get; set; }

        [JsonProperty("ResourceLevel")]
        public int ResourceLevel { get; set; }
    }

    public class RisingDb_AchievementSubTaskData
    {

        [JsonProperty("TaskTitle")]
        public RisingDb_TaskTitle TaskTitle { get; set; }

        [JsonProperty("EntityCategory")]
        public RisingDb_EntityCategory3 EntityCategory { get; set; }

        [JsonProperty("PrefabReference")]
        public int PrefabReference { get; set; }

        [JsonProperty("TechReference")]
        public int TechReference { get; set; }

        [JsonProperty("RequiredCompletedCount")]
        public int RequiredCompletedCount { get; set; }

        [JsonProperty("ConditionId")]
        public int ConditionId { get; set; }

        [JsonProperty("ProgressType")]
        public string ProgressType { get; set; }

        [JsonProperty("ProgressLinkType")]
        public string ProgressLinkType { get; set; }
    }

    public class RisingDb_DropFromTablesOnGameplayEvent
    {

        [JsonProperty("EventIdIndex")]
        public int EventIdIndex { get; set; }

        [JsonProperty("EventIdCount")]
        public int EventIdCount { get; set; }

        [JsonProperty("DropTrigger")]
        public string DropTrigger { get; set; }

        [JsonProperty("DropAt")]
        public string DropAt { get; set; }

        [JsonProperty("ConditionIndex")]
        public int ConditionIndex { get; set; }
    }

    public class RisingDb_LastTargetEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_LookAtRootPos
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_NormalizedLookAtOffset
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_LastTarget2
    {

        [JsonProperty("Zoom")]
        public double Zoom { get; set; }

        [JsonProperty("LookAtRootPos")]
        public RisingDb_LookAtRootPos LookAtRootPos { get; set; }

        [JsonProperty("NormalizedLookAtOffset")]
        public RisingDb_NormalizedLookAtOffset NormalizedLookAtOffset { get; set; }

        [JsonProperty("Pitch")]
        public double Pitch { get; set; }
    }

    public class RisingDb_LookAtRootPos2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_NormalizedLookAtOffset2
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Target7
    {

        [JsonProperty("Zoom")]
        public double Zoom { get; set; }

        [JsonProperty("LookAtRootPos")]
        public RisingDb_LookAtRootPos2 LookAtRootPos { get; set; }

        [JsonProperty("NormalizedLookAtOffset")]
        public RisingDb_NormalizedLookAtOffset2 NormalizedLookAtOffset { get; set; }

        [JsonProperty("Pitch")]
        public double Pitch { get; set; }
    }

    public class RisingDb_LookAtRootPos3
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_NormalizedLookAtOffset3
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_Current2
    {

        [JsonProperty("Zoom")]
        public double Zoom { get; set; }

        [JsonProperty("LookAtRootPos")]
        public RisingDb_LookAtRootPos3 LookAtRootPos { get; set; }

        [JsonProperty("NormalizedLookAtOffset")]
        public RisingDb_NormalizedLookAtOffset3 NormalizedLookAtOffset { get; set; }

        [JsonProperty("Pitch")]
        public double Pitch { get; set; }
    }

    public class RisingDb_LastLookAtMouseOffset
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_FrozenMousePanPosition
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_RotatedLookAtOffset
    {

        [JsonProperty("x")]
        public double x { get; set; }

        [JsonProperty("y")]
        public double y { get; set; }

        [JsonProperty("z")]
        public double z { get; set; }
    }

    public class RisingDb_ZoomSettings
    {

        [JsonProperty("MinZoom")]
        public double MinZoom { get; set; }

        [JsonProperty("MaxZoom")]
        public double MaxZoom { get; set; }

        [JsonProperty("MaxPitch")]
        public double MaxPitch { get; set; }

        [JsonProperty("MinPitch")]
        public double MinPitch { get; set; }
    }

    public class RisingDb_TopdownCameraState
    {

        [JsonProperty("LastTargetEntity")]
        public RisingDb_LastTargetEntity LastTargetEntity { get; set; }

        [JsonProperty("Yaw")]
        public double Yaw { get; set; }

        [JsonProperty("PitchPercent")]
        public double PitchPercent { get; set; }

        [JsonProperty("LastTarget")]
        public RisingDb_LastTarget2 LastTarget { get; set; }

        [JsonProperty("Target")]
        public RisingDb_Target7 Target { get; set; }

        [JsonProperty("Current")]
        public RisingDb_Current2 Current { get; set; }

        [JsonProperty("LastLookAtMouseOffset")]
        public RisingDb_LastLookAtMouseOffset LastLookAtMouseOffset { get; set; }

        [JsonProperty("FrozenMousePanPosition")]
        public RisingDb_FrozenMousePanPosition FrozenMousePanPosition { get; set; }

        [JsonProperty("RotatedLookAtOffset")]
        public RisingDb_RotatedLookAtOffset RotatedLookAtOffset { get; set; }

        [JsonProperty("InBuildMode")]
        public bool InBuildMode { get; set; }

        [JsonProperty("EnableMousePanning")]
        public bool EnableMousePanning { get; set; }

        [JsonProperty("ZoomSettings")]
        public RisingDb_ZoomSettings ZoomSettings { get; set; }

        [JsonProperty("InstantJump")]
        public bool InstantJump { get; set; }
    }

    public class RisingDb_Value27
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }

        [JsonProperty("z")]
        public int z { get; set; }

        [JsonProperty("w")]
        public int w { get; set; }
    }

    public class RisingDb_FleeSoundGuid
    {

        [JsonProperty("Value")]
        public RisingDb_Value27 Value { get; set; }
    }

    public class RisingDb_MinMaxCritters
    {

        [JsonProperty("x")]
        public int x { get; set; }

        [JsonProperty("y")]
        public int y { get; set; }
    }

    public class RisingDb_CritterGroup
    {

        [JsonProperty("BaseCritterGuid")]
        public int BaseCritterGuid { get; set; }

        [JsonProperty("FleeSoundGuid")]
        public RisingDb_FleeSoundGuid FleeSoundGuid { get; set; }

        [JsonProperty("MinMaxCritters")]
        public RisingDb_MinMaxCritters MinMaxCritters { get; set; }

        [JsonProperty("ResetZoneRadius")]
        public double ResetZoneRadius { get; set; }

        [JsonProperty("ActivationZoneRadius")]
        public double ActivationZoneRadius { get; set; }

        [JsonProperty("EscapeZoneRadius")]
        public double EscapeZoneRadius { get; set; }

        [JsonProperty("SpawnZoneRadius")]
        public double SpawnZoneRadius { get; set; }

        [JsonProperty("MaxAliveTime")]
        public double MaxAliveTime { get; set; }

        [JsonProperty("CurrentAliveTime")]
        public double CurrentAliveTime { get; set; }

        [JsonProperty("NumCritters")]
        public int NumCritters { get; set; }

        [JsonProperty("InnerActiveSphere")]
        public string InnerActiveSphere { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("IsTemporary")]
        public bool IsTemporary { get; set; }

        [JsonProperty("HasFleeSoundEvent")]
        public bool HasFleeSoundEvent { get; set; }
    }

    public class RisingDb_BonusCustomTargetEntity
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_LerpLambdas
    {

        [JsonProperty("OrbitDistanceLambda")]
        public double OrbitDistanceLambda { get; set; }

        [JsonProperty("AnchorPositionLambda")]
        public double AnchorPositionLambda { get; set; }

        [JsonProperty("OrbitEulerLambda")]
        public double OrbitEulerLambda { get; set; }

        [JsonProperty("AnchorRotationLerpFactor")]
        public double AnchorRotationLerpFactor { get; set; }
    }

    public class RisingDb_OrbitCamera
    {

        [JsonProperty("LerpEnabled")]
        public bool LerpEnabled { get; set; }

        [JsonProperty("MinPitch")]
        public double MinPitch { get; set; }

        [JsonProperty("MaxPitch")]
        public double MaxPitch { get; set; }

        [JsonProperty("MinZoom")]
        public double MinZoom { get; set; }

        [JsonProperty("MaxZoom")]
        public double MaxZoom { get; set; }

        [JsonProperty("ZoomSpeed")]
        public double ZoomSpeed { get; set; }

        [JsonProperty("OverTheShoulderSensitivity")]
        public double OverTheShoulderSensitivity { get; set; }

        [JsonProperty("AnchorHeightSensitivity")]
        public double AnchorHeightSensitivity { get; set; }

        [JsonProperty("AutoRotationSensitivity")]
        public double AutoRotationSensitivity { get; set; }

        [JsonProperty("MouseRotationSensitivity")]
        public double MouseRotationSensitivity { get; set; }

        [JsonProperty("BonusCustomTargetEntity")]
        public RisingDb_BonusCustomTargetEntity BonusCustomTargetEntity { get; set; }

        [JsonProperty("LerpLambdas")]
        public RisingDb_LerpLambdas LerpLambdas { get; set; }
    }

    public class RisingDb_NotEnoughBloodManaKey
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_SCTTypeCollection
    {

        [JsonProperty("DamageDone_Type")]
        public int DamageDone_Type { get; set; }

        [JsonProperty("DamageTaken_Type")]
        public int DamageTaken_Type { get; set; }

        [JsonProperty("ResourceGain_Type")]
        public int ResourceGain_Type { get; set; }

        [JsonProperty("NeedBetterTool_Type")]
        public int NeedBetterTool_Type { get; set; }

        [JsonProperty("NeedExplosives_Type")]
        public int NeedExplosives_Type { get; set; }

        [JsonProperty("RequiresRecipe_Type")]
        public int RequiresRecipe_Type { get; set; }

        [JsonProperty("MissingMaterials_Type")]
        public int MissingMaterials_Type { get; set; }

        [JsonProperty("CritDamage_Type")]
        public int CritDamage_Type { get; set; }

        [JsonProperty("Healing_Type")]
        public int Healing_Type { get; set; }

        [JsonProperty("Absorb_Type")]
        public int Absorb_Type { get; set; }

        [JsonProperty("InventoryFull_Type")]
        public int InventoryFull_Type { get; set; }

        [JsonProperty("HaveEquippedItems_Type")]
        public int HaveEquippedItems_Type { get; set; }

        [JsonProperty("Generic_Type")]
        public int Generic_Type { get; set; }

        [JsonProperty("IgniteExtinguished_Type")]
        public int IgniteExtinguished_Type { get; set; }

        [JsonProperty("BloodEssence_Type")]
        public int BloodEssence_Type { get; set; }

        [JsonProperty("LocalChat_Type")]
        public int LocalChat_Type { get; set; }

        [JsonProperty("CastFailResult_Type")]
        public int CastFailResult_Type { get; set; }

        [JsonProperty("MAXHeal_Type")]
        public int MAXHeal_Type { get; set; }

        [JsonProperty("CannotTeleport_Type")]
        public int CannotTeleport_Type { get; set; }

        [JsonProperty("PvPProtectedOUT_Type")]
        public int PvPProtectedOUT_Type { get; set; }

        [JsonProperty("PvPProtectedIN_Type")]
        public int PvPProtectedIN_Type { get; set; }

        [JsonProperty("WoodenWall_Type")]
        public int WoodenWall_Type { get; set; }

        [JsonProperty("StoneWall_Type")]
        public int StoneWall_Type { get; set; }

        [JsonProperty("NotEnoughBloodManaKey")]
        public RisingDb_NotEnoughBloodManaKey NotEnoughBloodManaKey { get; set; }
    }

    public class RisingDb_DismantleTarget
    {

        [JsonProperty("Index")]
        public int Index { get; set; }

        [JsonProperty("Version")]
        public int Version { get; set; }
    }

    public class RisingDb_DismantleAbility
    {

        [JsonProperty("DismantleTarget")]
        public RisingDb_DismantleTarget DismantleTarget { get; set; }
    }

    public class RisingDb_Faction
    {
    }

    public class RisingDb_Name12
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Name13
    {

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }

    public class RisingDb_Tag
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }

        [JsonProperty("Name")]
        public RisingDb_Name13 Name { get; set; }

        [JsonProperty("Icon")]
        public string Icon { get; set; }
    }

    public class RisingDb_Category
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }

        [JsonProperty("Name")]
        public RisingDb_Name12 Name { get; set; }

        [JsonProperty("Icon")]
        public string Icon { get; set; }

        [JsonProperty("Tags")]
        public IList<RisingDb_Tag> Tags { get; set; }
    }

    public class RisingDb_ManagedBuildMenuCompositionData
    {

        [JsonProperty("GuidHash")]
        public int GuidHash { get; set; }

        [JsonProperty("Categories")]
        public IList<RisingDb_Category> Categories { get; set; }
    }

    public class RisingDb_BuildMenuComposition
    {
    }

    public class RisingDb_BuffResistanceElement
    {

        [JsonProperty("BuffCategory")]
        public string BuffCategory { get; set; }

        [JsonProperty("ModifyDuration")]
        public bool ModifyDuration { get; set; }

        [JsonProperty("DurationModifier")]
        public double DurationModifier { get; set; }
    }

    public class RisingDb_SiegeWeapon
    {

        [JsonProperty("BuffApplied")]
        public bool BuffApplied { get; set; }
    }

    public class RisingEntity
    {

        [JsonProperty("PrefabGuid")]
        public int PrefabGuid { get; set; }

        [JsonProperty("Entity_Self")]
        public RisingDb_Entity_Self Entity_Self { get; set; }

        [JsonProperty("PrefabName")]
        public string PrefabName { get; set; }

        [JsonProperty("Attach")]
        public RisingDb_Attach Attach { get; set; }

        [JsonProperty("EntityOwner")]
        public RisingDb_EntityOwner EntityOwner { get; set; }

        [JsonProperty("EntityCreator")]
        public RisingDb_EntityCreator EntityCreator { get; set; }

        [JsonProperty("Buff")]
        public RisingDb_Buff Buff { get; set; }

        [JsonProperty("HideWeapon")]
        public bool HideWeapon { get; set; }

        [JsonProperty("SpellTarget")]
        public RisingDb_SpellTarget SpellTarget { get; set; }

        [JsonProperty("DestroyData")]
        public RisingDb_DestroyData DestroyData { get; set; }

        [JsonProperty("DestroyState")]
        public RisingDb_DestroyState DestroyState { get; set; }

        [JsonProperty("Age")]
        public RisingDb_Age Age { get; set; }

        [JsonProperty("BuffCategory")]
        public RisingDb_BuffCategory BuffCategory { get; set; }

        [JsonProperty("LifeTime")]
        public RisingDb_LifeTime LifeTime { get; set; }

        [JsonProperty("ModifyRotation")]
        public bool ModifyRotation { get; set; }

        [JsonProperty("ShowOnBuffBar")]
        public bool ShowOnBuffBar { get; set; }

        [JsonProperty("SharedGameplayConditionReference")]
        public IList<RisingDb_SharedGameplayConditionReference> SharedGameplayConditionReference { get; set; }

        [JsonProperty("GameplayConditionGroup")]
        public IList<RisingDb_GameplayConditionGroup> GameplayConditionGroup { get; set; }

        [JsonProperty("GameplayCondition")]
        public IList<RisingDb_GameplayCondition> GameplayCondition { get; set; }

        [JsonProperty("LocalizedStringBuilderParameter")]
        public IList<RisingDb_LocalizedStringBuilderParameter> LocalizedStringBuilderParameter { get; set; }

        [JsonProperty("CreateGameplayEventsOnAbilityImpaired")]
        public IList<RisingDb_CreateGameplayEventsOnAbilityImpaired> CreateGameplayEventsOnAbilityImpaired { get; set; }

        [JsonProperty("CreateGameplayEventsOnAbilityTrigger")]
        public IList<RisingDb_CreateGameplayEventsOnAbilityTrigger> CreateGameplayEventsOnAbilityTrigger { get; set; }

        [JsonProperty("CreateGameplayEventsOnAbilityTriggerAbilityPrefabTargets")]
        public object CreateGameplayEventsOnAbilityTriggerAbilityPrefabTargets { get; set; }

        [JsonProperty("CreateGameplayEventsOnTick")]
        public IList<RisingDb_CreateGameplayEventsOnTick> CreateGameplayEventsOnTick { get; set; }

        [JsonProperty("DestroyOnGameplayEvent")]
        public IList<RisingDb_DestroyOnGameplayEvent> DestroyOnGameplayEvent { get; set; }

        [JsonProperty("GameplayEventIdMapping")]
        public IList<RisingDb_GameplayEventIdMapping> GameplayEventIdMapping { get; set; }

        [JsonProperty("ShowOnBuffBarData")]
        public bool ShowOnBuffBarData { get; set; }

        [JsonProperty("PrefabCollectionPrefabTag")]
        public bool PrefabCollectionPrefabTag { get; set; }

        [JsonProperty("UsesSpawnTag")]
        public bool UsesSpawnTag { get; set; }

        [JsonProperty("DestroyOnManualInterrupt")]
        public bool DestroyOnManualInterrupt { get; set; }

        [JsonProperty("MovementImpairBuff")]
        public bool MovementImpairBuff { get; set; }

        [JsonProperty("TechData")]
        public RisingDb_TechData TechData { get; set; }

        [JsonProperty("TechUnlockAbilityBuffer")]
        public IList<RisingDb_TechUnlockAbilityBuffer> TechUnlockAbilityBuffer { get; set; }

        [JsonProperty("TechUnlockRecipeBuffer")]
        public IList<RisingDb_TechUnlockRecipeBuffer> TechUnlockRecipeBuffer { get; set; }

        [JsonProperty("TechUnlockBlueprintBuffer")]
        public IList<RisingDb_TechUnlockBlueprintBuffer> TechUnlockBlueprintBuffer { get; set; }

        [JsonProperty("TechRequirementBuffer")]
        public IList<RisingDb_TechRequirementBuffer> TechRequirementBuffer { get; set; }

        [JsonProperty("TechItemRequirementBuffer")]
        public IList<RisingDb_TechItemRequirementBuffer> TechItemRequirementBuffer { get; set; }

        [JsonProperty("ProgressionBookShapeshiftElement")]
        public IList<RisingDb_ProgressionBookShapeshiftElement> ProgressionBookShapeshiftElement { get; set; }

        [JsonProperty("ManagedAbilityGroupData")]
        public RisingDb_ManagedAbilityGroupData ManagedAbilityGroupData { get; set; }

        [JsonProperty("AbilityTooltipData")]
        public RisingDb_AbilityTooltipData AbilityTooltipData { get; set; }

        [JsonProperty("AbilityGroupState")]
        public RisingDb_AbilityGroupState AbilityGroupState { get; set; }

        [JsonProperty("VBloodAbilityData")]
        public RisingDb_VBloodAbilityData VBloodAbilityData { get; set; }

        [JsonProperty("AbilityStateBuffer")]
        public IList<RisingDb_AbilityStateBuffer> AbilityStateBuffer { get; set; }

        [JsonProperty("AbilityCastCondition")]
        public IList<RisingDb_AbilityCastCondition> AbilityCastCondition { get; set; }

        [JsonProperty("AbilityGroupStartAbilitiesBuffer")]
        public IList<RisingDb_AbilityGroupStartAbilitiesBuffer> AbilityGroupStartAbilitiesBuffer { get; set; }

        [JsonProperty("EntitySpawnedMetadata")]
        public bool? EntitySpawnedMetadata { get; set; }

        [JsonProperty("EntityMetadata")]
        public bool? EntityMetadata { get; set; }

        [JsonProperty("AbilityState")]
        public RisingDb_AbilityState AbilityState { get; set; }

        [JsonProperty("ModifyRotationDuringCast")]
        public bool? ModifyRotationDuringCast { get; set; }

        [JsonProperty("AbilityCooldownState")]
        public RisingDb_AbilityCooldownState AbilityCooldownState { get; set; }

        [JsonProperty("AbilityCooldownData")]
        public RisingDb_AbilityCooldownData AbilityCooldownData { get; set; }

        [JsonProperty("EnergyRequirement")]
        public RisingDb_EnergyRequirement EnergyRequirement { get; set; }

        [JsonProperty("GlobalCooldown")]
        public RisingDb_GlobalCooldown GlobalCooldown { get; set; }

        [JsonProperty("MoveStopAbilityData")]
        public bool? MoveStopAbilityData { get; set; }

        [JsonProperty("AbilityPriority")]
        public bool? AbilityPriority { get; set; }

        [JsonProperty("AbilityCastTimeData")]
        public RisingDb_AbilityCastTimeData AbilityCastTimeData { get; set; }

        [JsonProperty("ModifyMovementDuringCastData")]
        public bool? ModifyMovementDuringCastData { get; set; }

        [JsonProperty("MoveDuringCastData")]
        public bool? MoveDuringCastData { get; set; }

        [JsonProperty("AbilitySpawnPrefabOnCast")]
        public IList<RisingDb_AbilitySpawnPrefabOnCast> AbilitySpawnPrefabOnCast { get; set; }

        [JsonProperty("AbilityCastSequenceData")]
        public IList<RisingDb_AbilityCastSequenceData> AbilityCastSequenceData { get; set; }

        [JsonProperty("MagicSourceDurabilityRequirement")]
        public RisingDb_MagicSourceDurabilityRequirement MagicSourceDurabilityRequirement { get; set; }

        [JsonProperty("Team")]
        public RisingDb_Team Team { get; set; }

        [JsonProperty("TargetAoE")]
        public RisingDb_TargetAoE TargetAoE { get; set; }

        [JsonProperty("JoinDefaultTeamOnSpawn")]
        public bool? JoinDefaultTeamOnSpawn { get; set; }

        [JsonProperty("ModifiableValueIds")]
        public RisingDb_ModifiableValueIds ModifiableValueIds { get; set; }

        [JsonProperty("GetOwnerRotation")]
        public bool? GetOwnerRotation { get; set; }

        [JsonProperty("GetOwnerTranslationOnSpawn")]
        public bool? GetOwnerTranslationOnSpawn { get; set; }

        [JsonProperty("RagdollForceSource")]
        public RisingDb_RagdollForceSource RagdollForceSource { get; set; }

        [JsonProperty("SpawnPrefabOnDestroy")]
        public bool? SpawnPrefabOnDestroy { get; set; }

        [JsonProperty("HitTrigger")]
        public object HitTrigger { get; set; }

        [JsonProperty("TargetAOESequence")]
        public IList<RisingDb_TargetAOESequence> TargetAOESequence { get; set; }

        [JsonProperty("HitColliderCast")]
        public IList<RisingDb_HitColliderCast> HitColliderCast { get; set; }

        [JsonProperty("GetOwnerRotationOnlyOnSpawnTag")]
        public bool? GetOwnerRotationOnlyOnSpawnTag { get; set; }

        [JsonProperty("GetOwnerTeamOnSpawn")]
        public bool? GetOwnerTeamOnSpawn { get; set; }

        [JsonProperty("CollisionCastOnDestroy")]
        public bool? CollisionCastOnDestroy { get; set; }

        [JsonProperty("CreateGameplayEventsOnSpawn")]
        public IList<RisingDb_CreateGameplayEventsOnSpawn> CreateGameplayEventsOnSpawn { get; set; }

        [JsonProperty("PlaySequenceOnGameplayEvent")]
        public IList<RisingDb_PlaySequenceOnGameplayEvent> PlaySequenceOnGameplayEvent { get; set; }

        [JsonProperty("RemoveBuffOnGameplayEvent")]
        public IList<RisingDb_RemoveBuffOnGameplayEvent> RemoveBuffOnGameplayEvent { get; set; }

        [JsonProperty("RemoveBuffOnGameplayEventEntry")]
        public IList<RisingDb_RemoveBuffOnGameplayEventEntry> RemoveBuffOnGameplayEventEntry { get; set; }

        [JsonProperty("DestroyOnSpawn")]
        public bool? DestroyOnSpawn { get; set; }

        [JsonProperty("AbilityGroupResetComboState")]
        public bool? AbilityGroupResetComboState { get; set; }

        [JsonProperty("ManagedCharacterHUD")]
        public RisingDb_ManagedCharacterHUD ManagedCharacterHUD { get; set; }

        [JsonProperty("AbilityBar_Client")]
        public RisingDb_AbilityBar_Client AbilityBar_Client { get; set; }

        [JsonProperty("AbilityBar_Shared")]
        public RisingDb_AbilityBar_Shared AbilityBar_Shared { get; set; }

        [JsonProperty("AggroConsumer")]
        public RisingDb_AggroConsumer AggroConsumer { get; set; }

        [JsonProperty("Follower")]
        public RisingDb_Follower Follower { get; set; }

        [JsonProperty("BuffResistances")]
        public RisingDb_BuffResistances BuffResistances { get; set; }

        [JsonProperty("EntityInput")]
        public RisingDb_EntityInput EntityInput { get; set; }

        [JsonProperty("DeadSequence")]
        public bool? DeadSequence { get; set; }

        [JsonProperty("Script_SCTChatOnAggro_Data")]
        public bool? Script_SCTChatOnAggro_Data { get; set; }

        [JsonProperty("Footstep")]
        public RisingDb_Footstep Footstep { get; set; }

        [JsonProperty("FactionReference")]
        public RisingDb_FactionReference FactionReference { get; set; }

        [JsonProperty("CharacterHUD")]
        public RisingDb_CharacterHUD CharacterHUD { get; set; }

        [JsonProperty("Buffable")]
        public RisingDb_Buffable Buffable { get; set; }

        [JsonProperty("Hideable")]
        public RisingDb_Hideable Hideable { get; set; }

        [JsonProperty("Stealthable")]
        public RisingDb_Stealthable Stealthable { get; set; }

        [JsonProperty("Health")]
        public RisingDb_Health Health { get; set; }

        [JsonProperty("HealthConstants")]
        public RisingDb_HealthConstants HealthConstants { get; set; }

        [JsonProperty("LastTranslation")]
        public RisingDb_LastTranslation LastTranslation { get; set; }

        [JsonProperty("Movement")]
        public RisingDb_Movement2 Movement { get; set; }

        [JsonProperty("CollisionRadius")]
        public RisingDb_CollisionRadius CollisionRadius { get; set; }

        [JsonProperty("MapCollision")]
        public RisingDb_MapCollision MapCollision { get; set; }

        [JsonProperty("Velocity")]
        public RisingDb_Velocity Velocity { get; set; }

        [JsonProperty("SpawnTransform")]
        public RisingDb_SpawnTransform SpawnTransform { get; set; }

        [JsonProperty("TargetDirection")]
        public RisingDb_TargetDirection TargetDirection { get; set; }

        [JsonProperty("TileBounds")]
        public RisingDb_TileBounds TileBounds { get; set; }

        [JsonProperty("TilePosition")]
        public bool? TilePosition { get; set; }

        [JsonProperty("TileModelSpatialData")]
        public bool? TileModelSpatialData { get; set; }

        [JsonProperty("TileData")]
        public RisingDb_TileData TileData { get; set; }

        [JsonProperty("EntityCategory")]
        public RisingDb_EntityCategory EntityCategory { get; set; }

        [JsonProperty("Immaterial")]
        public RisingDb_Immaterial Immaterial { get; set; }

        [JsonProperty("Invulnerable")]
        public bool? Invulnerable { get; set; }

        [JsonProperty("UnitLevel")]
        public RisingDb_UnitLevel UnitLevel { get; set; }

        [JsonProperty("Vision")]
        public RisingDb_Vision Vision { get; set; }

        [JsonProperty("EntityAimData")]
        public RisingDb_EntityAimData EntityAimData { get; set; }

        [JsonProperty("MoveVelocity")]
        public bool? MoveVelocity { get; set; }

        [JsonProperty("CanPreventDisableWhenNoPlayersInRange")]
        public bool? CanPreventDisableWhenNoPlayersInRange { get; set; }

        [JsonProperty("ResistanceData")]
        public RisingDb_ResistanceData ResistanceData { get; set; }

        [JsonProperty("UnitStats")]
        public RisingDb_UnitStats UnitStats { get; set; }

        [JsonProperty("AiMove_Shared")]
        public bool? AiMove_Shared { get; set; }

        [JsonProperty("MinionSpawnData")]
        public bool? MinionSpawnData { get; set; }

        [JsonProperty("GenericCombatMovementData")]
        public RisingDb_GenericCombatMovementData GenericCombatMovementData { get; set; }

        [JsonProperty("MiscAiGameplayData")]
        public RisingDb_MiscAiGameplayData MiscAiGameplayData { get; set; }

        [JsonProperty("ImpactMaterial")]
        public RisingDb_ImpactMaterial ImpactMaterial { get; set; }

        [JsonProperty("HybridModelOffset")]
        public bool? HybridModelOffset { get; set; }

        [JsonProperty("HybridModelSeed")]
        public RisingDb_HybridModelSeed HybridModelSeed { get; set; }

        [JsonProperty("TileModel")]
        public RisingDb_TileModel TileModel { get; set; }

        [JsonProperty("CheckOnScreen")]
        public RisingDb_CheckOnScreen CheckOnScreen { get; set; }

        [JsonProperty("PlacementDestroyData")]
        public RisingDb_PlacementDestroyData PlacementDestroyData { get; set; }

        [JsonProperty("CastleAreaRequirement")]
        public bool? CastleAreaRequirement { get; set; }

        [JsonProperty("Interactable")]
        public RisingDb_Interactable Interactable { get; set; }

        [JsonProperty("InteractedUpon")]
        public RisingDb_InteractedUpon InteractedUpon { get; set; }

        [JsonProperty("DynamicCollision")]
        public RisingDb_DynamicCollision DynamicCollision { get; set; }

        [JsonProperty("Height")]
        public RisingDb_Height Height { get; set; }

        [JsonProperty("IsSpellControlled")]
        public RisingDb_IsSpellControlled IsSpellControlled { get; set; }

        [JsonProperty("FadeOutObstacles")]
        public bool? FadeOutObstacles { get; set; }

        [JsonProperty("CharacterHeightHUD")]
        public bool? CharacterHeightHUD { get; set; }

        [JsonProperty("HealthBarHUD")]
        public RisingDb_HealthBarHUD HealthBarHUD { get; set; }

        [JsonProperty("CharacterHudProgressBar")]
        public bool? CharacterHudProgressBar { get; set; }

        [JsonProperty("AbilityGroupSlotBuffer")]
        public IList<RisingDb_AbilityGroupSlotBuffer> AbilityGroupSlotBuffer { get; set; }

        [JsonProperty("BoolModificationBuffer")]
        public object BoolModificationBuffer { get; set; }

        [JsonProperty("EntityModificationBuffer")]
        public object EntityModificationBuffer { get; set; }

        [JsonProperty("FloatModificationBuffer")]
        public object FloatModificationBuffer { get; set; }

        [JsonProperty("Float3ModificationBuffer")]
        public object Float3ModificationBuffer { get; set; }

        [JsonProperty("IntModificationBuffer")]
        public object IntModificationBuffer { get; set; }

        [JsonProperty("PrefabGUIDModificationBuffer")]
        public object PrefabGUIDModificationBuffer { get; set; }

        [JsonProperty("AnimationStateBuffer")]
        public IList<RisingDb_AnimationStateBuffer> AnimationStateBuffer { get; set; }

        [JsonProperty("InteractAbilityBuffer")]
        public IList<RisingDb_InteractAbilityBuffer> InteractAbilityBuffer { get; set; }

        [JsonProperty("DropTableBuffer")]
        public IList<RisingDb_DropTableBuffer> DropTableBuffer { get; set; }

        [JsonProperty("Script_SCTChatOnAggro_Buffer")]
        public IList<RisingDb_Script_SCTChatOnAggro_Buffer> Script_SCTChatOnAggro_Buffer { get; set; }

        [JsonProperty("UseHybridModel")]
        public bool? UseHybridModel { get; set; }

        [JsonProperty("CharmSource")]
        public bool? CharmSource { get; set; }

        [JsonProperty("MoveEntity")]
        public bool? MoveEntity { get; set; }

        [JsonProperty("TilePlacementTag")]
        public bool? TilePlacementTag { get; set; }

        [JsonProperty("MoveStopTrigger")]
        public bool? MoveStopTrigger { get; set; }

        [JsonProperty("SnapToHeight")]
        public bool? SnapToHeight { get; set; }

        [JsonProperty("HideOutsideVision")]
        public bool? HideOutsideVision { get; set; }

        [JsonProperty("DropTable")]
        public bool? DropTable { get; set; }

        [JsonProperty("DropTableOnDeath")]
        public bool? DropTableOnDeath { get; set; }

        [JsonProperty("AssignTeamColor")]
        public bool? AssignTeamColor { get; set; }

        [JsonProperty("TileModelRegistrationState")]
        public bool? TileModelRegistrationState { get; set; }

        [JsonProperty("TileModelLayer")]
        public bool? TileModelLayer { get; set; }

        [JsonProperty("ManagedBlueprintData")]
        public RisingDb_ManagedBlueprintData ManagedBlueprintData { get; set; }

        [JsonProperty("BlueprintData")]
        public RisingDb_BlueprintData BlueprintData { get; set; }

        [JsonProperty("EditableTileModel")]
        public RisingDb_EditableTileModel EditableTileModel { get; set; }

        [JsonProperty("EditableTileModel_Client")]
        public RisingDb_EditableTileModel_Client EditableTileModel_Client { get; set; }

        [JsonProperty("CastleAreaConnection")]
        public bool? CastleAreaConnection { get; set; }

        [JsonProperty("CastleHeartConnection")]
        public RisingDb_CastleHeartConnection CastleHeartConnection { get; set; }

        [JsonProperty("DismantleDestroyData")]
        public RisingDb_DismantleDestroyData DismantleDestroyData { get; set; }

        [JsonProperty("ProgressionUserContentDependency")]
        public RisingDb_ProgressionUserContentDependency ProgressionUserContentDependency { get; set; }

        [JsonProperty("CreatedTime")]
        public RisingDb_CreatedTime CreatedTime { get; set; }

        [JsonProperty("Immortal")]
        public RisingDb_Immortal Immortal { get; set; }

        [JsonProperty("StaticTransformCompatible")]
        public bool? StaticTransformCompatible { get; set; }

        [JsonProperty("CastleBuildingMaxRange")]
        public bool? CastleBuildingMaxRange { get; set; }

        [JsonProperty("StationMenuSounds")]
        public RisingDb_StationMenuSounds StationMenuSounds { get; set; }

        [JsonProperty("StaticHierarchyData")]
        public bool? StaticHierarchyData { get; set; }

        [JsonProperty("StaticHierarchyBuffer")]
        public IList<RisingDb_StaticHierarchyBuffer> StaticHierarchyBuffer { get; set; }

        [JsonProperty("CastleBuildingAttachToParentsBuffer")]
        public object CastleBuildingAttachToParentsBuffer { get; set; }

        [JsonProperty("CastleBuildingAttachedChildrenBuffer")]
        public object CastleBuildingAttachedChildrenBuffer { get; set; }

        [JsonProperty("BlueprintRequirementBuffer")]
        public IList<RisingDb_BlueprintRequirementBuffer> BlueprintRequirementBuffer { get; set; }

        [JsonProperty("TileCollisionTag")]
        public bool? TileCollisionTag { get; set; }

        [JsonProperty("TileSurfaceFluffTag")]
        public bool? TileSurfaceFluffTag { get; set; }

        [JsonProperty("TileLineOfSightTag")]
        public bool? TileLineOfSightTag { get; set; }

        [JsonProperty("DisableWhenNoPlayersInRange")]
        public bool? DisableWhenNoPlayersInRange { get; set; }

        [JsonProperty("RestrictPlacementToMapZones")]
        public bool? RestrictPlacementToMapZones { get; set; }

        [JsonProperty("DestroyWhenNoCharacterNearbyAfterDuration")]
        public bool? DestroyWhenNoCharacterNearbyAfterDuration { get; set; }

        [JsonProperty("StaticTileModel")]
        public bool? StaticTileModel { get; set; }

        [JsonProperty("InventoryOwner")]
        public RisingDb_InventoryOwner InventoryOwner { get; set; }

        [JsonProperty("Workstation")]
        public bool? Workstation { get; set; }

        [JsonProperty("CastleRoomConnection")]
        public RisingDb_CastleRoomConnection CastleRoomConnection { get; set; }

        [JsonProperty("InteractableSequence")]
        public bool? InteractableSequence { get; set; }

        [JsonProperty("ServantInteractPointLocalTransform")]
        public bool? ServantInteractPointLocalTransform { get; set; }

        [JsonProperty("StationServants")]
        public RisingDb_StationServants StationServants { get; set; }

        [JsonProperty("CastleWorkstation")]
        public RisingDb_CastleWorkstation CastleWorkstation { get; set; }

        [JsonProperty("CastleBuildingAttachSettings")]
        public RisingDb_CastleBuildingAttachSettings CastleBuildingAttachSettings { get; set; }

        [JsonProperty("InventoryBuffer")]
        public IList<RisingDb_InventoryBuffer> InventoryBuffer { get; set; }

        [JsonProperty("QueuedWorkstationCraftAction")]
        public object QueuedWorkstationCraftAction { get; set; }

        [JsonProperty("StationBonusBuffer")]
        public IList<RisingDb_StationBonusBuffer> StationBonusBuffer { get; set; }

        [JsonProperty("WorkstationRecipesBuffer")]
        public IList<RisingDb_WorkstationRecipesBuffer> WorkstationRecipesBuffer { get; set; }

        [JsonProperty("SpiderCocoon_DataShared")]
        public RisingDb_SpiderCocoon_DataShared SpiderCocoon_DataShared { get; set; }

        [JsonProperty("PlaySequenceOnDestroy")]
        public IList<RisingDb_PlaySequenceOnDestroy> PlaySequenceOnDestroy { get; set; }

        [JsonProperty("ScriptUpdate")]
        public bool? ScriptUpdate { get; set; }

        [JsonProperty("CastleFloor")]
        public bool? CastleFloor { get; set; }

        [JsonProperty("CastleFloorRoof")]
        public bool? CastleFloorRoof { get; set; }

        [JsonProperty("TerritoryTile")]
        public bool? TerritoryTile { get; set; }

        [JsonProperty("MapPylonArea")]
        public bool? MapPylonArea { get; set; }

        [JsonProperty("SceneryObjectBlocker")]
        public bool? SceneryObjectBlocker { get; set; }

        [JsonProperty("ProgressionDependencyElement")]
        public IList<RisingDb_ProgressionDependencyElement> ProgressionDependencyElement { get; set; }

        [JsonProperty("SnappingPoint")]
        public IList<RisingDb_SnappingPoint> SnappingPoint { get; set; }

        [JsonProperty("SnappingPointClosestTo")]
        public IList<RisingDb_SnappingPointClosestTo> SnappingPointClosestTo { get; set; }

        [JsonProperty("TileHeightTag")]
        public bool? TileHeightTag { get; set; }

        [JsonProperty("TileCastleAreaTag")]
        public bool? TileCastleAreaTag { get; set; }

        [JsonProperty("BuffSequenceSpawned")]
        public object BuffSequenceSpawned { get; set; }

        [JsonProperty("RunScriptOnGameplayEvent")]
        public IList<RisingDb_RunScriptOnGameplayEvent> RunScriptOnGameplayEvent { get; set; }

        [JsonProperty("BuffSequence")]
        public IList<RisingDb_BuffSequence> BuffSequence { get; set; }

        [JsonProperty("ReplaceAbilityOnSlotData")]
        public bool? ReplaceAbilityOnSlotData { get; set; }

        [JsonProperty("MountBuff_Sequence_DataServer")]
        public RisingDb_MountBuff_Sequence_DataServer MountBuff_Sequence_DataServer { get; set; }

        [JsonProperty("ModifyTargetHUDHeight")]
        public bool? ModifyTargetHUDHeight { get; set; }

        [JsonProperty("MountBuff")]
        public RisingDb_MountBuff MountBuff { get; set; }

        [JsonProperty("ModifyMovementSpeedBuff")]
        public bool? ModifyMovementSpeedBuff { get; set; }

        [JsonProperty("ZoomModifierBuff")]
        public bool? ZoomModifierBuff { get; set; }

        [JsonProperty("ModifyBloodDrainBuff")]
        public bool? ModifyBloodDrainBuff { get; set; }

        [JsonProperty("ReplaceAbilityOnSlotBuff")]
        public IList<RisingDb_ReplaceAbilityOnSlotBuff> ReplaceAbilityOnSlotBuff { get; set; }

        [JsonProperty("CreateGameplayEventOnDamageTaken")]
        public IList<RisingDb_CreateGameplayEventOnDamageTaken> CreateGameplayEventOnDamageTaken { get; set; }

        [JsonProperty("CreateGameplayEventsOnDestroy")]
        public IList<RisingDb_CreateGameplayEventsOnDestroy> CreateGameplayEventsOnDestroy { get; set; }

        [JsonProperty("Hideable_CopyFromAttachParent")]
        public bool? Hideable_CopyFromAttachParent { get; set; }

        [JsonProperty("AbilityTargetSource")]
        public bool? AbilityTargetSource { get; set; }

        [JsonProperty("RotationImpairBuff")]
        public bool? RotationImpairBuff { get; set; }

        [JsonProperty("SpawnPhysicsObjectOnDeath")]
        public bool? SpawnPhysicsObjectOnDeath { get; set; }

        [JsonProperty("RespawnPoint")]
        public RisingDb_RespawnPoint RespawnPoint { get; set; }

        [JsonProperty("UserOwner")]
        public RisingDb_UserOwner UserOwner { get; set; }

        [JsonProperty("Residency")]
        public bool? Residency { get; set; }

        [JsonProperty("AttachMapIconsToEntity")]
        public IList<RisingDb_AttachMapIconsToEntity> AttachMapIconsToEntity { get; set; }

        [JsonProperty("MapIconPerUserData")]
        public IList<RisingDb_MapIconPerUserData> MapIconPerUserData { get; set; }

        [JsonProperty("LimitOnePerUser")]
        public bool? LimitOnePerUser { get; set; }

        [JsonProperty("NetherSpawnPosition")]
        public bool? NetherSpawnPosition { get; set; }

        [JsonProperty("ChunkWaypoint")]
        public RisingDb_ChunkWaypoint ChunkWaypoint { get; set; }

        [JsonProperty("CanFadeOut")]
        public bool? CanFadeOut { get; set; }

        [JsonProperty("FadeOutInfrontOfUnit")]
        public bool? FadeOutInfrontOfUnit { get; set; }

        [JsonProperty("EntitySequence")]
        public object EntitySequence { get; set; }

        [JsonProperty("FadeOutBuffer")]
        public IList<RisingDb_FadeOutBuffer> FadeOutBuffer { get; set; }

        [JsonProperty("SpawnEntitySequence")]
        public IList<RisingDb_SpawnEntitySequence> SpawnEntitySequence { get; set; }

        [JsonProperty("EndInteractableSequence")]
        public RisingDb_EndInteractableSequence EndInteractableSequence { get; set; }

        [JsonProperty("NameableInteractable")]
        public RisingDb_NameableInteractable NameableInteractable { get; set; }

        [JsonProperty("Restricted_InventoryBuffer")]
        public IList<RisingDb_Restricted_InventoryBuffer> Restricted_InventoryBuffer { get; set; }

        [JsonProperty("DestroyAfterDuration")]
        public RisingDb_DestroyAfterDuration DestroyAfterDuration { get; set; }

        [JsonProperty("DestroyAfterTimeOnInventoryChange")]
        public bool? DestroyAfterTimeOnInventoryChange { get; set; }

        [JsonProperty("DropInInventoryOnSpawn")]
        public bool? DropInInventoryOnSpawn { get; set; }

        [JsonProperty("BloodConsumeSource")]
        public RisingDb_BloodConsumeSource BloodConsumeSource { get; set; }

        [JsonProperty("WoundedConstants")]
        public RisingDb_WoundedConstants WoundedConstants { get; set; }

        [JsonProperty("DeathRagdollForce")]
        public RisingDb_DeathRagdollForce DeathRagdollForce { get; set; }

        [JsonProperty("TravelToTargetRadius")]
        public bool? TravelToTargetRadius { get; set; }

        [JsonProperty("AbilityChargesState")]
        public RisingDb_AbilityChargesState AbilityChargesState { get; set; }

        [JsonProperty("AbilityChargesData")]
        public RisingDb_AbilityChargesData AbilityChargesData { get; set; }

        [JsonProperty("AnimateDitherAlpha")]
        public bool? AnimateDitherAlpha { get; set; }

        [JsonProperty("ShaderProperty_AlphaMultiply")]
        public bool? ShaderProperty_AlphaMultiply { get; set; }

        [JsonProperty("ShaderProperty_BlinkColor")]
        public bool? ShaderProperty_BlinkColor { get; set; }

        [JsonProperty("ShaderProperty_DitherAlpha")]
        public bool? ShaderProperty_DitherAlpha { get; set; }

        [JsonProperty("ShaderProperty_DissolveColor")]
        public bool? ShaderProperty_DissolveColor { get; set; }

        [JsonProperty("ShaderProperty_DissolveHeightMultiplier")]
        public bool? ShaderProperty_DissolveHeightMultiplier { get; set; }

        [JsonProperty("WallpaperFadeOutBuffer")]
        public IList<RisingDb_WallpaperFadeOutBuffer> WallpaperFadeOutBuffer { get; set; }

        [JsonProperty("SpawnSequenceForEntity")]
        public bool? SpawnSequenceForEntity { get; set; }

        [JsonProperty("PlayerDeathContainer")]
        public bool? PlayerDeathContainer { get; set; }

        [JsonProperty("FallToHeight")]
        public bool? FallToHeight { get; set; }

        [JsonProperty("ItemPickup")]
        public bool? ItemPickup { get; set; }

        [JsonProperty("DestroyWhenInventoryIsEmpty")]
        public bool? DestroyWhenInventoryIsEmpty { get; set; }

        [JsonProperty("AbilityInterruptData")]
        public RisingDb_AbilityInterruptData AbilityInterruptData { get; set; }

        [JsonProperty("AbilityIgnoreSettings")]
        public RisingDb_AbilityIgnoreSettings AbilityIgnoreSettings { get; set; }

        [JsonProperty("HideWeaponDuringCast")]
        public bool? HideWeaponDuringCast { get; set; }

        [JsonProperty("VBloodShapeshiftData")]
        public bool? VBloodShapeshiftData { get; set; }

        [JsonProperty("VBloodPortraitData")]
        public RisingDb_VBloodPortraitData VBloodPortraitData { get; set; }

        [JsonProperty("VBloodConsumeSource")]
        public RisingDb_VBloodConsumeSource VBloodConsumeSource { get; set; }

        [JsonProperty("VBloodUnit")]
        public RisingDb_VBloodUnit VBloodUnit { get; set; }

        [JsonProperty("CombatMusicSource_Client")]
        public RisingDb_CombatMusicSource_Client CombatMusicSource_Client { get; set; }

        [JsonProperty("VBloodUnlockTechBuffer")]
        public IList<RisingDb_VBloodUnlockTechBuffer> VBloodUnlockTechBuffer { get; set; }

        [JsonProperty("AmplifyBuff")]
        public bool? AmplifyBuff { get; set; }

        [JsonProperty("RadialZone_Sequence")]
        public bool? RadialZone_Sequence { get; set; }

        [JsonProperty("RadialZone_Environment_Data")]
        public bool? RadialZone_Environment_Data { get; set; }

        [JsonProperty("RadialZone_Environment_HitSpheres")]
        public IList<RisingDb_RadialZone_Environment_HitSpheres> RadialZone_Environment_HitSpheres { get; set; }

        [JsonProperty("ScriptSpawn")]
        public bool? ScriptSpawn { get; set; }

        [JsonProperty("GarlicArea")]
        public bool? GarlicArea { get; set; }

        [JsonProperty("DealDamageOnGameplayEvent")]
        public IList<RisingDb_DealDamageOnGameplayEvent> DealDamageOnGameplayEvent { get; set; }

        [JsonProperty("CreateGameplayEventsOnHit")]
        public IList<RisingDb_CreateGameplayEventsOnHit> CreateGameplayEventsOnHit { get; set; }

        [JsonProperty("HealOnGameplayEvent")]
        public IList<RisingDb_HealOnGameplayEvent> HealOnGameplayEvent { get; set; }

        [JsonProperty("PlayBlinkSequenceOnGameplayEvent")]
        public IList<RisingDb_PlayBlinkSequenceOnGameplayEvent> PlayBlinkSequenceOnGameplayEvent { get; set; }

        [JsonProperty("SpawnPrefabOnGameplayEvent")]
        public IList<RisingDb_SpawnPrefabOnGameplayEvent> SpawnPrefabOnGameplayEvent { get; set; }

        [JsonProperty("CollisionCastOnSpawn")]
        public bool? CollisionCastOnSpawn { get; set; }

        [JsonProperty("Script_InspectTarget_Data")]
        public RisingDb_Script_InspectTarget_Data Script_InspectTarget_Data { get; set; }

        [JsonProperty("Torture")]
        public RisingDb_Torture Torture { get; set; }

        [JsonProperty("TechUnlockPassiveBuffer")]
        public IList<RisingDb_TechUnlockPassiveBuffer> TechUnlockPassiveBuffer { get; set; }

        [JsonProperty("ScriptDestroy")]
        public bool? ScriptDestroy { get; set; }

        [JsonProperty("AbsorbBuff")]
        public bool? AbsorbBuff { get; set; }

        [JsonProperty("ModifyUnitStatBuff_DOTS")]
        public IList<RisingDb_ModifyUnitStatBuff_DOTS> ModifyUnitStatBuff_DOTS { get; set; }

        [JsonProperty("Script_Buff_SetHybridModel_DataClient")]
        public bool? Script_Buff_SetHybridModel_DataClient { get; set; }

        [JsonProperty("SiegeWeaponAbsorbCapByServerSettings")]
        public bool? SiegeWeaponAbsorbCapByServerSettings { get; set; }

        [JsonProperty("ImmuneToSunBuff")]
        public bool? ImmuneToSunBuff { get; set; }

        [JsonProperty("AttachParentId")]
        public RisingDb_AttachParentId AttachParentId { get; set; }

        [JsonProperty("AttachedBuffer")]
        public IList<RisingDb_AttachedBuffer> AttachedBuffer { get; set; }

        [JsonProperty("Script_WarningCircle_Visuals_DataClient")]
        public RisingDb_Script_WarningCircle_Visuals_DataClient Script_WarningCircle_Visuals_DataClient { get; set; }

        [JsonProperty("YieldResourcesOnPickup")]
        public bool? YieldResourcesOnPickup { get; set; }

        [JsonProperty("Script_SCTChatOnSpawn_Data")]
        public RisingDb_Script_SCTChatOnSpawn_Data Script_SCTChatOnSpawn_Data { get; set; }

        [JsonProperty("Script_SCTChatOnSpawn_Buffer")]
        public IList<RisingDb_Script_SCTChatOnSpawn_Buffer> Script_SCTChatOnSpawn_Buffer { get; set; }

        [JsonProperty("InvulnerableBuff")]
        public bool? InvulnerableBuff { get; set; }

        [JsonProperty("CollisionCastOnUpdate")]
        public bool? CollisionCastOnUpdate { get; set; }

        [JsonProperty("ScaleHealthByPlayerCountBuff")]
        public bool? ScaleHealthByPlayerCountBuff { get; set; }

        [JsonProperty("InCombatBuff")]
        public bool? InCombatBuff { get; set; }

        [JsonProperty("UseCombatAnimationState")]
        public bool? UseCombatAnimationState { get; set; }

        [JsonProperty("SpawnChainBlueprint")]
        public RisingDb_SpawnChainBlueprint SpawnChainBlueprint { get; set; }

        [JsonProperty("IdleAISound")]
        public bool? IdleAISound { get; set; }

        [JsonProperty("IdleAISoundBuffer")]
        public IList<RisingDb_IdleAISoundBuffer> IdleAISoundBuffer { get; set; }

        [JsonProperty("UninitializedAISound")]
        public bool? UninitializedAISound { get; set; }

        [JsonProperty("StaticTransformIndex")]
        public bool? StaticTransformIndex { get; set; }

        [JsonProperty("HideTargetHUD")]
        public bool? HideTargetHUD { get; set; }

        [JsonProperty("ImmaterialBuff")]
        public bool? ImmaterialBuff { get; set; }

        [JsonProperty("DisableDynamicCollisionBuff")]
        public bool? DisableDynamicCollisionBuff { get; set; }

        [JsonProperty("AbilityTarget")]
        public RisingDb_AbilityTarget AbilityTarget { get; set; }

        [JsonProperty("UserTeam")]
        public RisingDb_UserTeam UserTeam { get; set; }

        [JsonProperty("TeamAllies")]
        public IList<RisingDb_TeamAlly> TeamAllies { get; set; }

        [JsonProperty("ModifyTeamBuff")]
        public bool? ModifyTeamBuff { get; set; }

        [JsonProperty("DisableAggroBuff")]
        public bool? DisableAggroBuff { get; set; }

        [JsonProperty("FollowBuffOwner")]
        public bool? FollowBuffOwner { get; set; }

        [JsonProperty("PreventDisableBuff")]
        public bool? PreventDisableBuff { get; set; }

        [JsonProperty("RunSetupGraphTag")]
        public bool? RunSetupGraphTag { get; set; }

        [JsonProperty("Pull_Entity")]
        public bool? Pull_Entity { get; set; }

        [JsonProperty("Attached")]
        public RisingDb_Attached Attached { get; set; }

        [JsonProperty("AttachedDepth")]
        public bool? AttachedDepth { get; set; }

        [JsonProperty("Pull_BuffTarget")]
        public bool? Pull_BuffTarget { get; set; }

        [JsonProperty("DropTableOnDestroy")]
        public bool? DropTableOnDestroy { get; set; }

        [JsonProperty("WallpaperSet")]
        public bool? WallpaperSet { get; set; }

        [JsonProperty("PhysicsParent")]
        public RisingDb_PhysicsParent PhysicsParent { get; set; }

        [JsonProperty("DoorChildren")]
        public IList<RisingDb_DoorChildren> DoorChildren { get; set; }

        [JsonProperty("ChildPrefabTag")]
        public bool? ChildPrefabTag { get; set; }

        [JsonProperty("CastleBuildingHideInPreview")]
        public bool? CastleBuildingHideInPreview { get; set; }

        [JsonProperty("GetOwnerPrimaryAggroTargetOnSpawn")]
        public bool? GetOwnerPrimaryAggroTargetOnSpawn { get; set; }

        [JsonProperty("HolyArea")]
        public bool? HolyArea { get; set; }

        [JsonProperty("StartGraveyardExitWaypoint")]
        public RisingDb_StartGraveyardExitWaypoint StartGraveyardExitWaypoint { get; set; }

        [JsonProperty("Door")]
        public RisingDb_Door Door { get; set; }

        [JsonProperty("DurabilityTarget")]
        public RisingDb_DurabilityTarget DurabilityTarget { get; set; }

        [JsonProperty("AnnounceCastleAttack")]
        public bool? AnnounceCastleAttack { get; set; }

        [JsonProperty("AnnounceCastleBreached")]
        public bool? AnnounceCastleBreached { get; set; }

        [JsonProperty("CastleWall")]
        public bool? CastleWall { get; set; }

        [JsonProperty("ChangeModelWhenDecaying")]
        public bool? ChangeModelWhenDecaying { get; set; }

        [JsonProperty("DeathPvPTimer")]
        public RisingDb_DeathPvPTimer DeathPvPTimer { get; set; }

        [JsonProperty("Dash")]
        public RisingDb_Dash Dash { get; set; }

        [JsonProperty("DashSpawn")]
        public bool? DashSpawn { get; set; }

        [JsonProperty("BlockFeedBuff")]
        public bool? BlockFeedBuff { get; set; }

        [JsonProperty("ServerControlsPositionBuff")]
        public bool? ServerControlsPositionBuff { get; set; }

        [JsonProperty("GenerateAggroOnGameplayEvent")]
        public IList<RisingDb_GenerateAggroOnGameplayEvent> GenerateAggroOnGameplayEvent { get; set; }

        [JsonProperty("SpawnSleepingBuff")]
        public bool? SpawnSleepingBuff { get; set; }

        [JsonProperty("InsideBuff")]
        public bool? InsideBuff { get; set; }

        [JsonProperty("DisableHeightCorrectionBuff")]
        public bool? DisableHeightCorrectionBuff { get; set; }

        [JsonProperty("DisableMapCollisionBuff")]
        public bool? DisableMapCollisionBuff { get; set; }

        [JsonProperty("Throw_Prefabs_To_Spawn")]
        public IList<RisingDb_Throw_Prefabs_To_Spawn> Throw_Prefabs_To_Spawn { get; set; }

        [JsonProperty("ServantPortraitData")]
        public RisingDb_ServantPortraitData ServantPortraitData { get; set; }

        [JsonProperty("ServantEquipment")]
        public RisingDb_ServantEquipment ServantEquipment { get; set; }

        [JsonProperty("ServantConnectedCoffin")]
        public RisingDb_ServantConnectedCoffin ServantConnectedCoffin { get; set; }

        [JsonProperty("ServantData")]
        public RisingDb_ServantData ServantData { get; set; }

        [JsonProperty("ServantPower")]
        public RisingDb_ServantPower ServantPower { get; set; }

        [JsonProperty("ServantPowerConstants")]
        public bool? ServantPowerConstants { get; set; }

        [JsonProperty("ServantTypeData")]
        public RisingDb_ServantTypeData ServantTypeData { get; set; }

        [JsonProperty("NPCServantColorIndex")]
        public RisingDb_NPCServantColorIndex NPCServantColorIndex { get; set; }

        [JsonProperty("OpenDoors")]
        public bool? OpenDoors { get; set; }

        [JsonProperty("ServantConvertable")]
        public RisingDb_ServantConvertable ServantConvertable { get; set; }

        [JsonProperty("OpenDoorsBuffer")]
        public object OpenDoorsBuffer { get; set; }

        [JsonProperty("PerksBuffer")]
        public IList<RisingDb_PerksBuffer> PerksBuffer { get; set; }

        [JsonProperty("ServantConvertRequirement")]
        public IList<RisingDb_ServantConvertRequirement> ServantConvertRequirement { get; set; }

        [JsonProperty("UnitLevelDamageSettings")]
        public IList<RisingDb_UnitLevelDamageSetting> UnitLevelDamageSettings { get; set; }

        [JsonProperty("RotateOverTimeData")]
        public RisingDb_RotateOverTimeData RotateOverTimeData { get; set; }

        [JsonProperty("CritterSpawn")]
        public bool? CritterSpawn { get; set; }

        [JsonProperty("Script_WarningCircle_Buff_Visuals_DataClient")]
        public RisingDb_Script_WarningCircle_Buff_Visuals_DataClient Script_WarningCircle_Buff_Visuals_DataClient { get; set; }

        [JsonProperty("SpawnRandomLifeTime")]
        public bool? SpawnRandomLifeTime { get; set; }

        [JsonProperty("DisabledWaitingForTransform")]
        public bool? DisabledWaitingForTransform { get; set; }

        [JsonProperty("AbilityOwner")]
        public RisingDb_AbilityOwner AbilityOwner { get; set; }

        [JsonProperty("GetOwnerFactionOnSpawn")]
        public bool? GetOwnerFactionOnSpawn { get; set; }

        [JsonProperty("UnitSpawnerstation")]
        public RisingDb_UnitSpawnerstation UnitSpawnerstation { get; set; }

        [JsonProperty("CastleLimited")]
        public bool? CastleLimited { get; set; }

        [JsonProperty("SpawnedUnitsBuffer")]
        public object SpawnedUnitsBuffer { get; set; }

        [JsonProperty("RefinementstationRecipesBuffer")]
        public IList<RisingDb_RefinementstationRecipesBuffer> RefinementstationRecipesBuffer { get; set; }

        [JsonProperty("Wallpaper_NotSplit")]
        public RisingDb_Wallpaper_NotSplit Wallpaper_NotSplit { get; set; }

        [JsonProperty("WallpaperStyles")]
        public RisingDb_WallpaperStyles WallpaperStyles { get; set; }

        [JsonProperty("WallpaperForceDamaged")]
        public RisingDb_WallpaperForceDamaged WallpaperForceDamaged { get; set; }

        [JsonProperty("WallpaperInstanceBuffer")]
        public object WallpaperInstanceBuffer { get; set; }

        [JsonProperty("Pylonstation")]
        public RisingDb_Pylonstation Pylonstation { get; set; }

        [JsonProperty("CastleHeart")]
        public RisingDb_CastleHeart CastleHeart { get; set; }

        [JsonProperty("PylonstationUpgradesBuffer")]
        public IList<RisingDb_PylonstationUpgradesBuffer> PylonstationUpgradesBuffer { get; set; }

        [JsonProperty("PylonstationCastleClaimBuffer")]
        public IList<RisingDb_PylonstationCastleClaimBuffer> PylonstationCastleClaimBuffer { get; set; }

        [JsonProperty("PylonstationCastleDestroyBuffer")]
        public IList<RisingDb_PylonstationCastleDestroyBuffer> PylonstationCastleDestroyBuffer { get; set; }

        [JsonProperty("ChunkWaypointSequence")]
        public bool? ChunkWaypointSequence { get; set; }

        [JsonProperty("Wallpaper_TwoSplits")]
        public RisingDb_Wallpaper_TwoSplits Wallpaper_TwoSplits { get; set; }

        [JsonProperty("Refinementstation")]
        public RisingDb_Refinementstation Refinementstation { get; set; }

        [JsonProperty("Wallpaper_FourSplits")]
        public RisingDb_Wallpaper_FourSplits Wallpaper_FourSplits { get; set; }

        [JsonProperty("RelicRadar")]
        public bool? RelicRadar { get; set; }

        [JsonProperty("ResearchStation")]
        public RisingDb_ResearchStation ResearchStation { get; set; }

        [JsonProperty("HaveUnlocksInStation")]
        public RisingDb_HaveUnlocksInStation HaveUnlocksInStation { get; set; }

        [JsonProperty("DiscoverCostBuffer")]
        public IList<RisingDb_DiscoverCostBuffer> DiscoverCostBuffer { get; set; }

        [JsonProperty("ResearchBuffer")]
        public IList<RisingDb_ResearchBuffer> ResearchBuffer { get; set; }

        [JsonProperty("Salvagestation")]
        public RisingDb_Salvagestation Salvagestation { get; set; }

        [JsonProperty("ActiveServantMission")]
        public object ActiveServantMission { get; set; }

        [JsonProperty("Relic")]
        public RisingDb_Relic Relic { get; set; }

        [JsonProperty("Bonfire")]
        public RisingDb_Bonfire Bonfire { get; set; }

        [JsonProperty("BurnContainer")]
        public RisingDb_BurnContainer BurnContainer { get; set; }

        [JsonProperty("CloudCookie")]
        public RisingDb_CloudCookie CloudCookie { get; set; }

        [JsonProperty("ManagedRepairStationData")]
        public RisingDb_ManagedRepairStationData ManagedRepairStationData { get; set; }

        [JsonProperty("RepairstationData")]
        public RisingDb_RepairstationData RepairstationData { get; set; }

        [JsonProperty("Repairstation")]
        public RisingDb_Repairstation Repairstation { get; set; }

        [JsonProperty("RepairRequirementBuffer")]
        public IList<RisingDb_RepairRequirementBuffer> RepairRequirementBuffer { get; set; }

        [JsonProperty("BloodAltar")]
        public RisingDb_BloodAltar BloodAltar { get; set; }

        [JsonProperty("BloodHuntBuffer")]
        public IList<RisingDb_BloodHuntBuffer> BloodHuntBuffer { get; set; }

        [JsonProperty("UpgradeableFromTileModel")]
        public RisingDb_UpgradeableFromTileModel UpgradeableFromTileModel { get; set; }

        [JsonProperty("ZoomModifierArea")]
        public bool? ZoomModifierArea { get; set; }

        [JsonProperty("ServantCoffinstation")]
        public RisingDb_ServantCoffinstation ServantCoffinstation { get; set; }

        [JsonProperty("ServantCoffinEffects")]
        public bool? ServantCoffinEffects { get; set; }

        [JsonProperty("PrisonCell")]
        public RisingDb_PrisonCell PrisonCell { get; set; }

        [JsonProperty("Prisonstation")]
        public bool? Prisonstation { get; set; }

        [JsonProperty("TravelBuff")]
        public RisingDb_TravelBuff TravelBuff { get; set; }

        [JsonProperty("TravelBuffSpawn")]
        public RisingDb_TravelBuffSpawn TravelBuffSpawn { get; set; }

        [JsonProperty("UseCharacterHudProgressBar")]
        public bool? UseCharacterHudProgressBar { get; set; }

        [JsonProperty("UseCharacterHudProgressBarManaged")]
        public bool? UseCharacterHudProgressBarManaged { get; set; }

        [JsonProperty("ChunkPortal")]
        public RisingDb_ChunkPortal ChunkPortal { get; set; }

        [JsonProperty("YieldResourceDisable")]
        public bool? YieldResourceDisable { get; set; }

        [JsonProperty("DestroyBuffOnMove")]
        public bool? DestroyBuffOnMove { get; set; }

        [JsonProperty("BloodShareBuff")]
        public bool? BloodShareBuff { get; set; }

        [JsonProperty("BloodShareBuff_ResetVBlood")]
        public bool? BloodShareBuff_ResetVBlood { get; set; }

        [JsonProperty("NeutralTeam")]
        public bool? NeutralTeam { get; set; }

        [JsonProperty("CastleRoofOrnaments")]
        public bool? CastleRoofOrnaments { get; set; }

        [JsonProperty("CreateGameplayEventOnItemEquipped")]
        public IList<RisingDb_CreateGameplayEventOnItemEquipped> CreateGameplayEventOnItemEquipped { get; set; }

        [JsonProperty("AdjustFlyHeightBuff")]
        public bool? AdjustFlyHeightBuff { get; set; }

        [JsonProperty("OffsetTranslationOnSpawn")]
        public bool? OffsetTranslationOnSpawn { get; set; }

        [JsonProperty("WeaponLevel")]
        public RisingDb_WeaponLevel2 WeaponLevel { get; set; }

        [JsonProperty("VBloodPassiveData")]
        public RisingDb_VBloodPassiveData VBloodPassiveData { get; set; }

        [JsonProperty("Knockback")]
        public RisingDb_Knockback Knockback { get; set; }

        [JsonProperty("RegenOnServerTick")]
        public bool? RegenOnServerTick { get; set; }

        [JsonProperty("CanFly")]
        public RisingDb_CanFly CanFly { get; set; }

        [JsonProperty("VisibleFromFlight")]
        public bool? VisibleFromFlight { get; set; }

        [JsonProperty("UnitUptimeSetting")]
        public bool? UnitUptimeSetting { get; set; }

        [JsonProperty("ChangeBloodOnGameplayEvent")]
        public IList<RisingDb_ChangeBloodOnGameplayEvent> ChangeBloodOnGameplayEvent { get; set; }

        [JsonProperty("ManagedMissionInjureDataAsset")]
        public RisingDb_ManagedMissionInjureDataAsset ManagedMissionInjureDataAsset { get; set; }

        [JsonProperty("CreateGameplayEventOnDeath")]
        public IList<RisingDb_CreateGameplayEventOnDeath> CreateGameplayEventOnDeath { get; set; }

        [JsonProperty("AmplifyStackModifier")]
        public bool? AmplifyStackModifier { get; set; }

        [JsonProperty("WeakenStackModifier")]
        public bool? WeakenStackModifier { get; set; }

        [JsonProperty("Script_GarlicAreaDebuff_DataShared")]
        public RisingDb_Script_GarlicAreaDebuff_DataShared Script_GarlicAreaDebuff_DataShared { get; set; }

        [JsonProperty("PhysicsRubble")]
        public RisingDb_PhysicsRubble PhysicsRubble { get; set; }

        [JsonProperty("EntityMatrixElement")]
        public IList<RisingDb_EntityMatrixElement> EntityMatrixElement { get; set; }

        [JsonProperty("SetOwnerRotateTowardsMovement")]
        public bool? SetOwnerRotateTowardsMovement { get; set; }

        [JsonProperty("MountInitBuff")]
        public bool? MountInitBuff { get; set; }

        [JsonProperty("AbilityGroupComboState")]
        public RisingDb_AbilityGroupComboState AbilityGroupComboState { get; set; }

        [JsonProperty("HasResidentBuff")]
        public bool? HasResidentBuff { get; set; }

        [JsonProperty("ManagedItemData")]
        public RisingDb_ManagedItemData ManagedItemData { get; set; }

        [JsonProperty("ItemData")]
        public RisingDb_ItemData ItemData { get; set; }

        [JsonProperty("Salvageable")]
        public RisingDb_Salvageable Salvageable { get; set; }

        [JsonProperty("CastAbilityOnConsume")]
        public RisingDb_CastAbilityOnConsume CastAbilityOnConsume { get; set; }

        [JsonProperty("RecipeRequirementBuffer")]
        public IList<RisingDb_RecipeRequirementBuffer> RecipeRequirementBuffer { get; set; }

        [JsonProperty("ConsumableCondition")]
        public object ConsumableCondition { get; set; }

        [JsonProperty("RequiredProgressionToConsume")]
        public IList<RisingDb_RequiredProgressionToConsume> RequiredProgressionToConsume { get; set; }

        [JsonProperty("ProgressionBookRecipeElement")]
        public IList<RisingDb_ProgressionBookRecipeElement> ProgressionBookRecipeElement { get; set; }

        [JsonProperty("ProgressionBookTechElement")]
        public IList<RisingDb_ProgressionBookTechElement> ProgressionBookTechElement { get; set; }

        [JsonProperty("ProgressionBookBlueprintElement")]
        public IList<RisingDb_ProgressionBookBlueprintElement> ProgressionBookBlueprintElement { get; set; }

        [JsonProperty("InventoryItem")]
        public bool? InventoryItem { get; set; }

        [JsonProperty("Consumable")]
        public bool? Consumable { get; set; }

        [JsonProperty("InsideInitBuff")]
        public bool? InsideInitBuff { get; set; }

        [JsonProperty("Projectile")]
        public RisingDb_Projectile Projectile { get; set; }

        [JsonProperty("ProjectileDestroyData")]
        public bool? ProjectileDestroyData { get; set; }

        [JsonProperty("SpellMovement")]
        public bool? SpellMovement { get; set; }

        [JsonProperty("ProjectileSnapToHeight")]
        public bool? ProjectileSnapToHeight { get; set; }

        [JsonProperty("TravelToTarget")]
        public bool? TravelToTarget { get; set; }

        [JsonProperty("Script_Siphon_Blood_Buff_DataShared")]
        public RisingDb_Script_Siphon_Blood_Buff_DataShared Script_Siphon_Blood_Buff_DataShared { get; set; }

        [JsonProperty("Script_Siphon_Blood_Buff_DataClient")]
        public RisingDb_Script_Siphon_Blood_Buff_DataClient Script_Siphon_Blood_Buff_DataClient { get; set; }

        [JsonProperty("CreateGameplayEventsOnTimePassed")]
        public IList<RisingDb_CreateGameplayEventsOnTimePassed> CreateGameplayEventsOnTimePassed { get; set; }

        [JsonProperty("ForceCastOnGameplayEvent")]
        public IList<RisingDb_ForceCastOnGameplayEvent> ForceCastOnGameplayEvent { get; set; }

        [JsonProperty("DecayOnServerTick")]
        public bool? DecayOnServerTick { get; set; }

        [JsonProperty("SetDynamicCollisionHardnessBuff")]
        public bool? SetDynamicCollisionHardnessBuff { get; set; }

        [JsonProperty("Script_SetFlyingHeightVision_Buff_DataShared")]
        public RisingDb_Script_SetFlyingHeightVision_Buff_DataShared Script_SetFlyingHeightVision_Buff_DataShared { get; set; }

        [JsonProperty("CanFlyBuff")]
        public bool? CanFlyBuff { get; set; }

        [JsonProperty("AlwaysInSunBuff")]
        public bool? AlwaysInSunBuff { get; set; }

        [JsonProperty("FlyOnlyMapCollisionBuff")]
        public bool? FlyOnlyMapCollisionBuff { get; set; }

        [JsonProperty("BuildMenuImpairBuff")]
        public bool? BuildMenuImpairBuff { get; set; }

        [JsonProperty("Script_Buff_GrabToOwner_DataServer")]
        public RisingDb_Script_Buff_GrabToOwner_DataServer Script_Buff_GrabToOwner_DataServer { get; set; }

        [JsonProperty("AbilityChargeResetOnUse")]
        public bool? AbilityChargeResetOnUse { get; set; }

        [JsonProperty("InteractPickup")]
        public bool? InteractPickup { get; set; }

        [JsonProperty("Script_SalvageOnGameplayEventData")]
        public RisingDb_Script_SalvageOnGameplayEventData Script_SalvageOnGameplayEventData { get; set; }

        [JsonProperty("DestroyOnAbilityCast")]
        public bool? DestroyOnAbilityCast { get; set; }

        [JsonProperty("CreateGameplayEventsOnDirectionalShieldTrigger")]
        public IList<RisingDb_CreateGameplayEventsOnDirectionalShieldTrigger> CreateGameplayEventsOnDirectionalShieldTrigger { get; set; }

        [JsonProperty("LimitAbilityPriorityBuff")]
        public bool? LimitAbilityPriorityBuff { get; set; }

        [JsonProperty("Script_Summon_Castle_DataShared")]
        public RisingDb_Script_Summon_Castle_DataShared Script_Summon_Castle_DataShared { get; set; }

        [JsonProperty("Script_ToggleNearbyArmorRacks_DataShared")]
        public RisingDb_Script_ToggleNearbyArmorRacks_DataShared Script_ToggleNearbyArmorRacks_DataShared { get; set; }

        [JsonProperty("Script_SetWeaponRunCycle_DataClient")]
        public RisingDb_Script_SetWeaponRunCycle_DataClient Script_SetWeaponRunCycle_DataClient { get; set; }

        [JsonProperty("ModifyAggroRangesBuff")]
        public bool? ModifyAggroRangesBuff { get; set; }

        [JsonProperty("RingAoE_DataShared")]
        public RisingDb_RingAoE_DataShared RingAoE_DataShared { get; set; }

        [JsonProperty("Script_DamageZone_SingleTarget_Shared")]
        public RisingDb_Script_DamageZone_SingleTarget_Shared Script_DamageZone_SingleTarget_Shared { get; set; }

        [JsonProperty("OpenDoor")]
        public bool? OpenDoor { get; set; }

        [JsonProperty("CastleResistanceBuff")]
        public bool? CastleResistanceBuff { get; set; }

        [JsonProperty("Script_Wounded_DataShared")]
        public RisingDb_Script_Wounded_DataShared Script_Wounded_DataShared { get; set; }

        [JsonProperty("MountedAbilityCastSequence_DataServer")]
        public RisingDb_MountedAbilityCastSequence_DataServer MountedAbilityCastSequence_DataServer { get; set; }

        [JsonProperty("RunScriptOnCastEnded")]
        public bool? RunScriptOnCastEnded { get; set; }

        [JsonProperty("Script_BloodAltar_TrackVBloodUnit_Client")]
        public RisingDb_Script_BloodAltar_TrackVBloodUnit_Client Script_BloodAltar_TrackVBloodUnit_Client { get; set; }

        [JsonProperty("Script_BloodAltar_TrackVBloodUnit_Shared")]
        public RisingDb_Script_BloodAltar_TrackVBloodUnit_Shared Script_BloodAltar_TrackVBloodUnit_Shared { get; set; }

        [JsonProperty("Script_BloodAltar_TrackVBloodUnit_Entry")]
        public object Script_BloodAltar_TrackVBloodUnit_Entry { get; set; }

        [JsonProperty("Script_Blood_CrimsonBeam_DataShared")]
        public RisingDb_Script_Blood_CrimsonBeam_DataShared Script_Blood_CrimsonBeam_DataShared { get; set; }

        [JsonProperty("Script_Blood_CrimsonBeam_DataClient")]
        public RisingDb_Script_Blood_CrimsonBeam_DataClient Script_Blood_CrimsonBeam_DataClient { get; set; }

        [JsonProperty("Script_Blood_CrimsonBeam_HitSequenceElement")]
        public IList<RisingDb_Script_Blood_CrimsonBeam_HitSequenceElement> Script_Blood_CrimsonBeam_HitSequenceElement { get; set; }

        [JsonProperty("TravelBuffSequence")]
        public IList<RisingDb_TravelBuffSequence> TravelBuffSequence { get; set; }

        [JsonProperty("Script_SilverDebuff_DataClient")]
        public RisingDb_Script_SilverDebuff_DataClient Script_SilverDebuff_DataClient { get; set; }

        [JsonProperty("Script_Buff_SetBuffTargetPositionToOwner_DataServer")]
        public RisingDb_Script_Buff_SetBuffTargetPositionToOwner_DataServer Script_Buff_SetBuffTargetPositionToOwner_DataServer { get; set; }

        [JsonProperty("Mount_Travel_DataShared")]
        public RisingDb_Mount_Travel_DataShared Mount_Travel_DataShared { get; set; }

        [JsonProperty("GrabBuff")]
        public bool? GrabBuff { get; set; }

        [JsonProperty("VampireDownedBuff")]
        public RisingDb_VampireDownedBuff VampireDownedBuff { get; set; }

        [JsonProperty("Script_CreateGameplayEventOnTickAfterDelay_DataServer")]
        public RisingDb_Script_CreateGameplayEventOnTickAfterDelay_DataServer Script_CreateGameplayEventOnTickAfterDelay_DataServer { get; set; }

        [JsonProperty("DropItemImpairedBuff")]
        public bool? DropItemImpairedBuff { get; set; }

        [JsonProperty("EquipmentImpairedBuff")]
        public bool? EquipmentImpairedBuff { get; set; }

        [JsonProperty("ReviveCancelBuff")]
        public bool? ReviveCancelBuff { get; set; }

        [JsonProperty("ChangeKnockbackResistanceDuringCast")]
        public RisingDb_ChangeKnockbackResistanceDuringCast ChangeKnockbackResistanceDuringCast { get; set; }

        [JsonProperty("AbilityGroupConsumeItemOnCast")]
        public RisingDb_AbilityGroupConsumeItemOnCast AbilityGroupConsumeItemOnCast { get; set; }

        [JsonProperty("Blood")]
        public RisingDb_Blood Blood { get; set; }

        [JsonProperty("Equipment")]
        public RisingDb_Equipment Equipment { get; set; }

        [JsonProperty("LowHealthEffect")]
        public bool? LowHealthEffect { get; set; }

        [JsonProperty("PlayerCharacter")]
        public RisingDb_PlayerCharacter PlayerCharacter { get; set; }

        [JsonProperty("ReturnToNetherWaypoint")]
        public bool? ReturnToNetherWaypoint { get; set; }

        [JsonProperty("BloodMoonBuffState")]
        public bool? BloodMoonBuffState { get; set; }

        [JsonProperty("Mounter")]
        public RisingDb_Mounter Mounter { get; set; }

        [JsonProperty("Resident")]
        public bool? Resident { get; set; }

        [JsonProperty("TakeDamageInSun")]
        public RisingDb_TakeDamageInSun TakeDamageInSun { get; set; }

        [JsonProperty("TakeDamageInSunDebuffState")]
        public bool? TakeDamageInSunDebuffState { get; set; }

        [JsonProperty("ControlledBy")]
        public RisingDb_ControlledBy ControlledBy { get; set; }

        [JsonProperty("CombatMusicListener_Client")]
        public bool? CombatMusicListener_Client { get; set; }

        [JsonProperty("Interactor")]
        public RisingDb_Interactor Interactor { get; set; }

        [JsonProperty("Picker")]
        public RisingDb_Picker Picker { get; set; }

        [JsonProperty("RespawnCharacter")]
        public RisingDb_RespawnCharacter RespawnCharacter { get; set; }

        [JsonProperty("CustomizationFeatures")]
        public RisingDb_CustomizationFeatures CustomizationFeatures { get; set; }

        [JsonProperty("CurrentGender")]
        public RisingDb_CurrentGender CurrentGender { get; set; }

        [JsonProperty("Energy")]
        public RisingDb_Energy Energy { get; set; }

        [JsonProperty("BloodMoonBuff")]
        public bool? BloodMoonBuff { get; set; }

        [JsonProperty("KeepMountBuffOnAbilityImpair")]
        public RisingDb_KeepMountBuffOnAbilityImpair KeepMountBuffOnAbilityImpair { get; set; }

        [JsonProperty("LifeLeech")]
        public RisingDb_LifeLeech LifeLeech { get; set; }

        [JsonProperty("CombatMusicListener_Shared")]
        public RisingDb_CombatMusicListener_Shared CombatMusicListener_Shared { get; set; }

        [JsonProperty("JumpFromCliffs")]
        public RisingDb_JumpFromCliffs JumpFromCliffs { get; set; }

        [JsonProperty("CharacterVoiceActivity")]
        public RisingDb_CharacterVoiceActivity CharacterVoiceActivity { get; set; }

        [JsonProperty("PathRecorder")]
        public bool? PathRecorder { get; set; }

        [JsonProperty("RestrictPlacementArea")]
        public bool? RestrictPlacementArea { get; set; }

        [JsonProperty("HybridModelUser")]
        public RisingDb_HybridModelUser HybridModelUser { get; set; }

        [JsonProperty("FollowerBuffer")]
        public object FollowerBuffer { get; set; }

        [JsonProperty("VBloodAbilityBuffEntry")]
        public object VBloodAbilityBuffEntry { get; set; }

        [JsonProperty("EquipmentSetBuff")]
        public object EquipmentSetBuff { get; set; }

        [JsonProperty("PathRecorderEntry")]
        public IList<RisingDb_PathRecorderEntry> PathRecorderEntry { get; set; }

        [JsonProperty("TileRestrictionAreaTag")]
        public bool? TileRestrictionAreaTag { get; set; }

        [JsonProperty("RadialDamageTarget")]
        public bool? RadialDamageTarget { get; set; }

        [JsonProperty("DisabledTileModel")]
        public bool? DisabledTileModel { get; set; }

        [JsonProperty("VampireTag")]
        public bool? VampireTag { get; set; }

        [JsonProperty("Script_SetHealthToOwnerPercentage_DataServer")]
        public bool? Script_SetHealthToOwnerPercentage_DataServer { get; set; }

        [JsonProperty("BuffAimPreview")]
        public bool? BuffAimPreview { get; set; }

        [JsonProperty("GoToHUDMenu")]
        public bool? GoToHUDMenu { get; set; }

        [JsonProperty("UseThrone")]
        public bool? UseThrone { get; set; }

        [JsonProperty("DestroyBuffOnDamageTaken")]
        public bool? DestroyBuffOnDamageTaken { get; set; }

        [JsonProperty("MoveTowardsRotationBuff")]
        public bool? MoveTowardsRotationBuff { get; set; }

        [JsonProperty("TeleportBuff")]
        public bool? TeleportBuff { get; set; }

        [JsonProperty("FadeToBlack")]
        public bool? FadeToBlack { get; set; }

        [JsonProperty("FadeToBlack_Manual")]
        public RisingDb_FadeToBlack_Manual FadeToBlack_Manual { get; set; }

        [JsonProperty("KeepMountBuffOnAbilityImpairBuff")]
        public bool? KeepMountBuffOnAbilityImpairBuff { get; set; }

        [JsonProperty("ProgressionGainXPLevelWisdom")]
        public RisingDb_ProgressionGainXPLevelWisdom ProgressionGainXPLevelWisdom { get; set; }

        [JsonProperty("ChangeAbilityOnGameplayEvent")]
        public IList<RisingDb_ChangeAbilityOnGameplayEvent> ChangeAbilityOnGameplayEvent { get; set; }

        [JsonProperty("AbilityCastAimPreview")]
        public RisingDb_AbilityCastAimPreview AbilityCastAimPreview { get; set; }

        [JsonProperty("AbilityHoldToCastData")]
        public bool? AbilityHoldToCastData { get; set; }

        [JsonProperty("FeedableInventory")]
        public RisingDb_FeedableInventory FeedableInventory { get; set; }

        [JsonProperty("Mountable")]
        public RisingDb_Mountable Mountable { get; set; }

        [JsonProperty("UseRelicRadar")]
        public bool? UseRelicRadar { get; set; }

        [JsonProperty("IgnoreInCombatBuff")]
        public bool? IgnoreInCombatBuff { get; set; }

        [JsonProperty("DamagedEditableTile")]
        public bool? DamagedEditableTile { get; set; }

        [JsonProperty("MultiplyAbsorbCapBySpellPower")]
        public bool? MultiplyAbsorbCapBySpellPower { get; set; }

        [JsonProperty("RepairData")]
        public bool? RepairData { get; set; }

        [JsonProperty("Script_BloodKey_SenseCastle_SharedData")]
        public RisingDb_Script_BloodKey_SenseCastle_SharedData Script_BloodKey_SenseCastle_SharedData { get; set; }

        [JsonProperty("Script_BloodKey_SenseCastle_EffectEntry")]
        public object Script_BloodKey_SenseCastle_EffectEntry { get; set; }

        [JsonProperty("Script_BloodKey_SenseCastle_BeamEntry")]
        public object Script_BloodKey_SenseCastle_BeamEntry { get; set; }

        [JsonProperty("Script_BloodKey_SenseCastle_Entry")]
        public object Script_BloodKey_SenseCastle_Entry { get; set; }

        [JsonProperty("HolyAreaDebuff")]
        public bool? HolyAreaDebuff { get; set; }

        [JsonProperty("ManagedDescriptionData")]
        public RisingDb_ManagedDescriptionData ManagedDescriptionData { get; set; }

        [JsonProperty("Script_PlaySequenceInSun_DataShared")]
        public RisingDb_Script_PlaySequenceInSun_DataShared Script_PlaySequenceInSun_DataShared { get; set; }

        [JsonProperty("Description")]
        public RisingDb_Description8 Description { get; set; }

        [JsonProperty("PlaceTilemodelAbility")]
        public RisingDb_PlaceTilemodelAbility PlaceTilemodelAbility { get; set; }

        [JsonProperty("CastleTeam")]
        public bool? CastleTeam { get; set; }

        [JsonProperty("HandledEvent")]
        public bool? HandledEvent { get; set; }

        [JsonProperty("CameraUser")]
        public RisingDb_CameraUser CameraUser { get; set; }

        [JsonProperty("ProgressionMapper")]
        public RisingDb_ProgressionMapper ProgressionMapper { get; set; }

        [JsonProperty("Controller")]
        public RisingDb_Controller2 Controller { get; set; }

        [JsonProperty("AchievementOwner")]
        public RisingDb_AchievementOwner AchievementOwner { get; set; }

        [JsonProperty("CurrentMapZone")]
        public RisingDb_CurrentMapZone CurrentMapZone { get; set; }

        [JsonProperty("ClanRole")]
        public RisingDb_ClanRole ClanRole { get; set; }

        [JsonProperty("CryptSelection")]
        public RisingDb_CryptSelection CryptSelection { get; set; }

        [JsonProperty("Emoter")]
        public bool? Emoter { get; set; }

        [JsonProperty("UserHealth")]
        public RisingDb_UserHealth UserHealth { get; set; }

        [JsonProperty("Shapeshift")]
        public RisingDb_Shapeshift Shapeshift { get; set; }

        [JsonProperty("CurrentWorldRegion")]
        public bool? CurrentWorldRegion { get; set; }

        [JsonProperty("Experience")]
        public RisingDb_Experience Experience { get; set; }

        [JsonProperty("IndoorMusic")]
        public bool? IndoorMusic { get; set; }

        [JsonProperty("AllyPermission")]
        public IList<RisingDb_AllyPermission> AllyPermission { get; set; }

        [JsonProperty("UnlockedWaypointElement")]
        public IList<RisingDb_UnlockedWaypointElement> UnlockedWaypointElement { get; set; }

        [JsonProperty("RespawnPointOwnerBuffer")]
        public IList<RisingDb_RespawnPointOwnerBuffer> RespawnPointOwnerBuffer { get; set; }

        [JsonProperty("UserMapZoneElement")]
        public IList<RisingDb_UserMapZoneElement> UserMapZoneElement { get; set; }

        [JsonProperty("DefaultAction")]
        public IList<RisingDb_DefaultAction> DefaultAction { get; set; }

        [JsonProperty("EmoteAbility")]
        public IList<RisingDb_EmoteAbility> EmoteAbility { get; set; }

        [JsonProperty("ShapeshiftAbility")]
        public IList<RisingDb_ShapeshiftAbility> ShapeshiftAbility { get; set; }

        [JsonProperty("KeyboardInput")]
        public bool? KeyboardInput { get; set; }

        [JsonProperty("DeathBuff")]
        public bool? DeathBuff { get; set; }

        [JsonProperty("RagdollifyBuffTarget")]
        public bool? RagdollifyBuffTarget { get; set; }

        [JsonProperty("MapIconData")]
        public bool? MapIconData { get; set; }

        [JsonProperty("MapIconTargetEntity")]
        public RisingDb_MapIconTargetEntity MapIconTargetEntity { get; set; }

        [JsonProperty("MapIconPosition")]
        public RisingDb_MapIconPosition MapIconPosition { get; set; }

        [JsonProperty("TeamBoundMapIcon")]
        public RisingDb_TeamBoundMapIcon TeamBoundMapIcon { get; set; }

        [JsonProperty("ScreenEdgeIcon")]
        public bool? ScreenEdgeIcon { get; set; }

        [JsonProperty("DataClient")]
        public RisingDb_DataClient DataClient { get; set; }

        [JsonProperty("DayNightCycle")]
        public RisingDb_DayNightCycle DayNightCycle { get; set; }

        [JsonProperty("AbilityGroupSlot")]
        public RisingDb_AbilityGroupSlot AbilityGroupSlot { get; set; }

        [JsonProperty("UnlockedProgressionElement")]
        public IList<RisingDb_UnlockedProgressionElement> UnlockedProgressionElement { get; set; }

        [JsonProperty("UnlockedShapeshiftElement")]
        public IList<RisingDb_UnlockedShapeshiftElement> UnlockedShapeshiftElement { get; set; }

        [JsonProperty("UnlockedRecipeElement")]
        public IList<RisingDb_UnlockedRecipeElement> UnlockedRecipeElement { get; set; }

        [JsonProperty("UnlockedBlueprintElement")]
        public IList<RisingDb_UnlockedBlueprintElement> UnlockedBlueprintElement { get; set; }

        [JsonProperty("UnlockedPassiveElement")]
        public object UnlockedPassiveElement { get; set; }

        [JsonProperty("UnlockedAbilityElement")]
        public IList<RisingDb_UnlockedAbilityElement> UnlockedAbilityElement { get; set; }

        [JsonProperty("UnlockedVBlood")]
        public object UnlockedVBlood { get; set; }

        [JsonProperty("Equippable")]
        public RisingDb_Equippable Equippable { get; set; }

        [JsonProperty("EquippableData")]
        public RisingDb_EquippableData EquippableData { get; set; }

        [JsonProperty("WeaponLevelSource")]
        public RisingDb_WeaponLevelSource WeaponLevelSource { get; set; }

        [JsonProperty("Durability")]
        public RisingDb_Durability Durability { get; set; }

        [JsonProperty("GiveAchievementOnItemCraft")]
        public bool? GiveAchievementOnItemCraft { get; set; }

        [JsonProperty("ReplaceAbilityOnSlotWhenMountedBuffElement")]
        public IList<RisingDb_ReplaceAbilityOnSlotWhenMountedBuffElement> ReplaceAbilityOnSlotWhenMountedBuffElement { get; set; }

        [JsonProperty("ReplaceAbilityOnSlotWhenMountedBuffModificationElement")]
        public object ReplaceAbilityOnSlotWhenMountedBuffModificationElement { get; set; }

        [JsonProperty("HybridEquipment")]
        public bool? HybridEquipment { get; set; }

        [JsonProperty("ClanTeam")]
        public RisingDb_ClanTeam ClanTeam { get; set; }

        [JsonProperty("CreateGameplayEventOnLeaveCliff")]
        public IList<RisingDb_CreateGameplayEventOnLeaveCliff> CreateGameplayEventOnLeaveCliff { get; set; }

        [JsonProperty("TimeScale")]
        public bool? TimeScale { get; set; }

        [JsonProperty("ItemBuilding")]
        public RisingDb_ItemBuilding ItemBuilding { get; set; }

        [JsonProperty("WorldZoneId")]
        public bool? WorldZoneId { get; set; }

        [JsonProperty("ServerTime")]
        public bool? ServerTime { get; set; }

        [JsonProperty("FeedPrisoner")]
        public RisingDb_FeedPrisoner FeedPrisoner { get; set; }

        [JsonProperty("SpellLevelSource")]
        public RisingDb_SpellLevelSource SpellLevelSource { get; set; }

        [JsonProperty("RespawnDelay")]
        public bool? RespawnDelay { get; set; }

        [JsonProperty("CastleIsland")]
        public RisingDb_CastleIsland CastleIsland { get; set; }

        [JsonProperty("ProgressAchievementOnItemGain")]
        public bool? ProgressAchievementOnItemGain { get; set; }

        [JsonProperty("SyncedServerDebugSettings")]
        public RisingDb_SyncedServerDebugSettings SyncedServerDebugSettings { get; set; }

        [JsonProperty("SpawnLocationSelector")]
        public RisingDb_SpawnLocationSelector SpawnLocationSelector { get; set; }

        [JsonProperty("SetOwnerRotateTowardsMouse")]
        public bool? SetOwnerRotateTowardsMouse { get; set; }

        [JsonProperty("UserBoundMapIconSource")]
        public bool? UserBoundMapIconSource { get; set; }

        [JsonProperty("PlayMountedSequence")]
        public bool? PlayMountedSequence { get; set; }

        [JsonProperty("PlayerMapIcon")]
        public RisingDb_PlayerMapIcon PlayerMapIcon { get; set; }

        [JsonProperty("RotateTowardsAimDirectionDuringCastData")]
        public bool? RotateTowardsAimDirectionDuringCastData { get; set; }

        [JsonProperty("HeadgearToggleData")]
        public bool? HeadgearToggleData { get; set; }

        [JsonProperty("AchievementInProgressElement")]
        public IList<RisingDb_AchievementInProgressElement> AchievementInProgressElement { get; set; }

        [JsonProperty("AchievementClaimedElement")]
        public IList<RisingDb_AchievementClaimedElement> AchievementClaimedElement { get; set; }

        [JsonProperty("ServerDebugViewData")]
        public RisingDb_ServerDebugViewData ServerDebugViewData { get; set; }

        [JsonProperty("JumpFromCliffsTravelBuff")]
        public bool? JumpFromCliffsTravelBuff { get; set; }

        [JsonProperty("WaypointMapIcon")]
        public RisingDb_WaypointMapIcon WaypointMapIcon { get; set; }

        [JsonProperty("AbilityRemoveBuffCategoryOnStartCast")]
        public RisingDb_AbilityRemoveBuffCategoryOnStartCast AbilityRemoveBuffCategoryOnStartCast { get; set; }

        [JsonProperty("Equipped")]
        public bool? Equipped { get; set; }

        [JsonProperty("VBloodBoundMapIcon")]
        public bool? VBloodBoundMapIcon { get; set; }

        [JsonProperty("ClanInviteRequest")]
        public bool? ClanInviteRequest { get; set; }

        [JsonProperty("CastleClaimData")]
        public bool? CastleClaimData { get; set; }

        [JsonProperty("CastleClaimRequirementBuffer")]
        public IList<RisingDb_CastleClaimRequirementBuffer> CastleClaimRequirementBuffer { get; set; }

        [JsonProperty("ManagedPerkData")]
        public RisingDb_ManagedPerkData ManagedPerkData { get; set; }

        [JsonProperty("PerkData")]
        public RisingDb_PerkData PerkData { get; set; }

        [JsonProperty("CastleDestroyData")]
        public bool? CastleDestroyData { get; set; }

        [JsonProperty("CastleDestroyRequirementBuffer")]
        public IList<RisingDb_CastleDestroyRequirementBuffer> CastleDestroyRequirementBuffer { get; set; }

        [JsonProperty("BloodBuff")]
        public bool? BloodBuff { get; set; }

        [JsonProperty("EmpowerBuff")]
        public bool? EmpowerBuff { get; set; }

        [JsonProperty("SequenceStressTest")]
        public bool? SequenceStressTest { get; set; }

        [JsonProperty("UseMirror")]
        public bool? UseMirror { get; set; }

        [JsonProperty("ManagedAchievementData")]
        public RisingDb_ManagedAchievementData ManagedAchievementData { get; set; }

        [JsonProperty("AchievementData")]
        public RisingDb_AchievementData AchievementData { get; set; }

        [JsonProperty("AchievementSubTaskEntry")]
        public IList<RisingDb_AchievementSubTaskEntry> AchievementSubTaskEntry { get; set; }

        [JsonProperty("ModifyObstacleFadeoutBuff")]
        public bool? ModifyObstacleFadeoutBuff { get; set; }

        [JsonProperty("RagdollSourceSetting")]
        public RisingDb_RagdollSourceSetting RagdollSourceSetting { get; set; }

        [JsonProperty("EquipmentSetElements")]
        public IList<RisingDb_EquipmentSetElement> EquipmentSetElements { get; set; }

        [JsonProperty("EquipmentSet")]
        public IList<RisingDb_EquipmentSet> EquipmentSet { get; set; }

        [JsonProperty("Script_WerewolfChieftain_ToggleGates_DataShared")]
        public RisingDb_Script_WerewolfChieftain_ToggleGates_DataShared Script_WerewolfChieftain_ToggleGates_DataShared { get; set; }

        [JsonProperty("RepairAbility")]
        public RisingDb_RepairAbility RepairAbility { get; set; }

        [JsonProperty("ManagedJournalTooltip")]
        public RisingDb_ManagedJournalTooltip ManagedJournalTooltip { get; set; }

        [JsonProperty("JournalTooltip")]
        public bool? JournalTooltip { get; set; }

        [JsonProperty("RecipeData")]
        public RisingDb_RecipeData RecipeData { get; set; }

        [JsonProperty("RecipeOutputBuffer")]
        public IList<RisingDb_RecipeOutputBuffer> RecipeOutputBuffer { get; set; }

        [JsonProperty("RecipeOutputUnitBuffer")]
        public IList<RisingDb_RecipeOutputUnitBuffer> RecipeOutputUnitBuffer { get; set; }

        [JsonProperty("VBloodItemSource")]
        public RisingDb_VBloodItemSource VBloodItemSource { get; set; }

        [JsonProperty("ImpactMaterialMappingBuffer")]
        public IList<RisingDb_ImpactMaterialMappingBuffer> ImpactMaterialMappingBuffer { get; set; }

        [JsonProperty("UpgradeData")]
        public bool? UpgradeData { get; set; }

        [JsonProperty("UpgradeRequirementBuffer")]
        public IList<RisingDb_UpgradeRequirementBuffer> UpgradeRequirementBuffer { get; set; }

        [JsonProperty("ManagedDataDropGroup")]
        public RisingDb_ManagedDataDropGroup ManagedDataDropGroup { get; set; }

        [JsonProperty("ItemDataDropGroup")]
        public bool? ItemDataDropGroup { get; set; }

        [JsonProperty("ItemDataDropGroupBuffer")]
        public IList<RisingDb_ItemDataDropGroupBuffer> ItemDataDropGroupBuffer { get; set; }

        [JsonProperty("DamageReductionPerTarget")]
        public RisingDb_DamageReductionPerTarget DamageReductionPerTarget { get; set; }

        [JsonProperty("DamageReductionPerTargetElement")]
        public object DamageReductionPerTargetElement { get; set; }

        [JsonProperty("UnitTeam")]
        public bool? UnitTeam { get; set; }

        [JsonProperty("ArmorLevelSource")]
        public RisingDb_ArmorLevelSource ArmorLevelSource { get; set; }

        [JsonProperty("StoredBlood")]
        public RisingDb_StoredBlood StoredBlood { get; set; }

        [JsonProperty("SunDamageDebuff")]
        public bool? SunDamageDebuff { get; set; }

        [JsonProperty("LifeLeechSetting")]
        public IList<RisingDb_LifeLeechSetting> LifeLeechSetting { get; set; }

        [JsonProperty("ServerDebugLogs")]
        public RisingDb_ServerDebugLogs ServerDebugLogs { get; set; }

        [JsonProperty("ManagedMissionData")]
        public RisingDb_ManagedMissionData ManagedMissionData { get; set; }

        [JsonProperty("MissionData")]
        public RisingDb_MissionData MissionData { get; set; }

        [JsonProperty("LifeLeechOnGameplayEvent")]
        public IList<RisingDb_LifeLeechOnGameplayEvent> LifeLeechOnGameplayEvent { get; set; }

        [JsonProperty("GiveAchievementOnHit")]
        public bool? GiveAchievementOnHit { get; set; }

        [JsonProperty("DayTimeSpan")]
        public RisingDb_DayTimeSpan2 DayTimeSpan { get; set; }

        [JsonProperty("StartGraveyardMapIcon")]
        public RisingDb_StartGraveyardMapIcon StartGraveyardMapIcon { get; set; }

        [JsonProperty("ClanSystemSettingsComponent")]
        public RisingDb_ClanSystemSettingsComponent ClanSystemSettingsComponent { get; set; }

        [JsonProperty("ManagedUnitBloodTypeData")]
        public RisingDb_ManagedUnitBloodTypeData ManagedUnitBloodTypeData { get; set; }

        [JsonProperty("UnitBloodTypeBuffs")]
        public IList<RisingDb_UnitBloodTypeBuff> UnitBloodTypeBuffs { get; set; }

        [JsonProperty("DropTableData")]
        public RisingDb_DropTableData DropTableData { get; set; }

        [JsonProperty("DropTableDataBuffer")]
        public IList<RisingDb_DropTableDataBuffer> DropTableDataBuffer { get; set; }

        [JsonProperty("GeneralGameplayCollection")]
        public RisingDb_GeneralGameplayCollection GeneralGameplayCollection { get; set; }

        [JsonProperty("ScrollingCombatTextMessage")]
        public bool? ScrollingCombatTextMessage { get; set; }

        [JsonProperty("ScrollingCombatText")]
        public bool? ScrollingCombatText { get; set; }

        [JsonProperty("PrefabSetBuffer")]
        public IList<RisingDb_PrefabSetBuffer> PrefabSetBuffer { get; set; }

        [JsonProperty("PrefabSetSourceObjectBuffer")]
        public IList<RisingDb_PrefabSetSourceObjectBuffer> PrefabSetSourceObjectBuffer { get; set; }

        [JsonProperty("CharacterCustomizationSettingsComponent")]
        public RisingDb_CharacterCustomizationSettingsComponent CharacterCustomizationSettingsComponent { get; set; }

        [JsonProperty("MaleFacesEntry")]
        public IList<RisingDb_MaleFacesEntry> MaleFacesEntry { get; set; }

        [JsonProperty("MaleHairsEntry")]
        public IList<RisingDb_MaleHairsEntry> MaleHairsEntry { get; set; }

        [JsonProperty("MaleFeaturesEntry")]
        public IList<RisingDb_MaleFeaturesEntry> MaleFeaturesEntry { get; set; }

        [JsonProperty("MaleAccessoriesEntry")]
        public IList<RisingDb_MaleAccessoriesEntry> MaleAccessoriesEntry { get; set; }

        [JsonProperty("FemaleFacesEntry")]
        public IList<RisingDb_FemaleFacesEntry> FemaleFacesEntry { get; set; }

        [JsonProperty("FemaleHairsEntry")]
        public IList<RisingDb_FemaleHairsEntry> FemaleHairsEntry { get; set; }

        [JsonProperty("FemaleFeaturesEntry")]
        public IList<RisingDb_FemaleFeaturesEntry> FemaleFeaturesEntry { get; set; }

        [JsonProperty("FemaleAccessoriesEntry")]
        public IList<RisingDb_FemaleAccessoriesEntry> FemaleAccessoriesEntry { get; set; }

        [JsonProperty("UseWaypoint")]
        public RisingDb_UseWaypoint UseWaypoint { get; set; }

        [JsonProperty("CastleRoom")]
        public RisingDb_CastleRoom CastleRoom { get; set; }

        [JsonProperty("AbsorbStackModifier")]
        public bool? AbsorbStackModifier { get; set; }

        [JsonProperty("AbsorbCapStackModifier")]
        public bool? AbsorbCapStackModifier { get; set; }

        [JsonProperty("ItemRepairBuffer")]
        public IList<RisingDb_ItemRepairBuffer> ItemRepairBuffer { get; set; }

        [JsonProperty("FreeCamera")]
        public bool? FreeCamera { get; set; }

        [JsonProperty("CameraTarget")]
        public RisingDb_CameraTarget CameraTarget { get; set; }

        [JsonProperty("FreeCameraState")]
        public RisingDb_FreeCameraState FreeCameraState { get; set; }

        [JsonProperty("HybridCameraData")]
        public RisingDb_HybridCameraData HybridCameraData { get; set; }

        [JsonProperty("StudioListener")]
        public bool? StudioListener { get; set; }

        [JsonProperty("HybridCameraFrustumPlanes")]
        public IList<RisingDb_HybridCameraFrustumPlane> HybridCameraFrustumPlanes { get; set; }

        [JsonProperty("HybridCamera")]
        public bool? HybridCamera { get; set; }

        [JsonProperty("CharacterHUDEntryCollection")]
        public bool? CharacterHUDEntryCollection { get; set; }

        [JsonProperty("VBloodEmoteData")]
        public bool? VBloodEmoteData { get; set; }

        [JsonProperty("AimPreview")]
        public bool? AimPreview { get; set; }

        [JsonProperty("AimPreviewTravelBuff")]
        public bool? AimPreviewTravelBuff { get; set; }

        [JsonProperty("GlobalCastleManager")]
        public RisingDb_GlobalCastleManager GlobalCastleManager { get; set; }

        [JsonProperty("GlobalCastleManagerBuffer")]
        public object GlobalCastleManagerBuffer { get; set; }

        [JsonProperty("ManagedStationBonusData")]
        public RisingDb_ManagedStationBonusData ManagedStationBonusData { get; set; }

        [JsonProperty("StationBonusData")]
        public bool? StationBonusData { get; set; }

        [JsonProperty("AimPreviewProjectileCursor")]
        public bool? AimPreviewProjectileCursor { get; set; }

        [JsonProperty("IgnorePvETag")]
        public bool? IgnorePvETag { get; set; }

        [JsonProperty("CritterData")]
        public RisingDb_CritterData CritterData { get; set; }

        [JsonProperty("MiscItemLevel")]
        public bool? MiscItemLevel { get; set; }

        [JsonProperty("NoFadeOut")]
        public bool? NoFadeOut { get; set; }

        [JsonProperty("RagdollDriver")]
        public RisingDb_RagdollDriver RagdollDriver { get; set; }

        [JsonProperty("RagdollBoneEntityElement")]
        public IList<RisingDb_RagdollBoneEntityElement> RagdollBoneEntityElement { get; set; }

        [JsonProperty("RagdollBoneTransformElement")]
        public IList<RisingDb_RagdollBoneTransformElement> RagdollBoneTransformElement { get; set; }

        [JsonProperty("AchievementSubTaskData")]
        public RisingDb_AchievementSubTaskData AchievementSubTaskData { get; set; }

        [JsonProperty("GallopBuff")]
        public bool? GallopBuff { get; set; }

        [JsonProperty("DropFromTablesOnGameplayEvent")]
        public IList<RisingDb_DropFromTablesOnGameplayEvent> DropFromTablesOnGameplayEvent { get; set; }

        [JsonProperty("SelectStartGraveyard")]
        public bool? SelectStartGraveyard { get; set; }

        [JsonProperty("TopdownCameraState")]
        public RisingDb_TopdownCameraState TopdownCameraState { get; set; }

        [JsonProperty("TopdownCamera")]
        public bool? TopdownCamera { get; set; }

        [JsonProperty("HybridCameraInstancedTag")]
        public bool? HybridCameraInstancedTag { get; set; }

        [JsonProperty("AimPreviewTargetAoE")]
        public bool? AimPreviewTargetAoE { get; set; }

        [JsonProperty("FadeOutFlyMoodBuff")]
        public bool? FadeOutFlyMoodBuff { get; set; }

        [JsonProperty("RadialDamageDebuff")]
        public bool? RadialDamageDebuff { get; set; }

        [JsonProperty("CritterGroup")]
        public RisingDb_CritterGroup CritterGroup { get; set; }

        [JsonProperty("CritterDataBuffer")]
        public object CritterDataBuffer { get; set; }

        [JsonProperty("AimPreviewDash")]
        public bool? AimPreviewDash { get; set; }

        [JsonProperty("VBloodAbilityReplaceBuff")]
        public bool? VBloodAbilityReplaceBuff { get; set; }

        [JsonProperty("AimPreviewMelee")]
        public bool? AimPreviewMelee { get; set; }

        [JsonProperty("OrbitCamera")]
        public RisingDb_OrbitCamera OrbitCamera { get; set; }

        [JsonProperty("OrbitCameraState")]
        public bool? OrbitCameraState { get; set; }

        [JsonProperty("SCTTypeCollection")]
        public RisingDb_SCTTypeCollection SCTTypeCollection { get; set; }

        [JsonProperty("DropTableOnSalvageDestroy")]
        public bool? DropTableOnSalvageDestroy { get; set; }

        [JsonProperty("HealingBuff")]
        public bool? HealingBuff { get; set; }

        [JsonProperty("AimPreviewProjectile")]
        public bool? AimPreviewProjectile { get; set; }

        [JsonProperty("DismantleAbility")]
        public RisingDb_DismantleAbility DismantleAbility { get; set; }

        [JsonProperty("Faction")]
        public RisingDb_Faction Faction { get; set; }

        [JsonProperty("ManagedBuildMenuCompositionData")]
        public RisingDb_ManagedBuildMenuCompositionData ManagedBuildMenuCompositionData { get; set; }

        [JsonProperty("BuildMenuComposition")]
        public RisingDb_BuildMenuComposition BuildMenuComposition { get; set; }

        [JsonProperty("IgnoreHitsPerTarget")]
        public bool? IgnoreHitsPerTarget { get; set; }

        [JsonProperty("IgnoreHitsPerTargetElement")]
        public object IgnoreHitsPerTargetElement { get; set; }

        [JsonProperty("BuffResistanceElement")]
        public IList<RisingDb_BuffResistanceElement> BuffResistanceElement { get; set; }

        [JsonProperty("SiegeWeapon")]
        public RisingDb_SiegeWeapon SiegeWeapon { get; set; }

        [JsonProperty("AnnounceSiegeWeapon")]
        public bool? AnnounceSiegeWeapon { get; set; }
    }

}
