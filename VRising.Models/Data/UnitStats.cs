namespace VRising.Models.Data
{
    public class UnitStats
    {
        public float PhysicalCriticalStrikeChance { get; set; }
        public float PhysicalCriticalStrikeDamage { get; set; }
        public float SpellCriticalStrikeChance { get; set; }
        public float SpellCriticalStrikeDamage { get; set; }
        public float PhysicalPower { get; set; }
        public float SpellPower { get; set; }
        public float ResourcePower { get; set; }
        public float SiegePower { get; set; }
        public float ResourceYieldModifier { get; set; }
        public float ReducedResourceDurabilityLoss { get; set; }
        public float PhysicalResistance { get; set; }
        public float SpellResistance { get; set; }
        public int SunResistance { get; set; }
        public int FireResistance { get; set; }
        public int HolyResistance { get; set; }
        public int SilverResistance { get; set; }
        public int GarlicResistance { get; set; }
        public float PassiveHealthRegen { get; set; }
        public float AttackSpeed { get; set; }
        public float PrimaryAttackSpeed { get; set; }
        public float DamageVsUndeads { get; set; }
        public float DamageVsHumans { get; set; }
        public float DamageVsDemons { get; set; }
        public float DamageVsMechanical { get; set; }
        public float DamageVsBeasts { get; set; }
        public float DamageVsCastleObjects { get; set; }
        public float DamageVsPlayerVampires { get; set; }
        public float ResistVsUndeads { get; set; }
        public float ResistVsHumans { get; set; }
        public float ResistVsDemons { get; set; }
        public float ResistVsMechanical { get; set; }
        public float ResistVsBeasts { get; set; }
        public float ResistVsPlayerVampires { get; set; }
        public float DamageVsWood { get; set; }
        public float DamageVsMineral { get; set; }
        public float DamageVsVegetation { get; set; }
        public float DamageVsLightArmor { get; set; }
        public float DamageVsHeavyArmor { get; set; }
        public float DamageVsMagic { get; set; }
        public bool ImmuneToHazards { get; set; }
        public bool PvPProtected { get; set; }
        public float HealthRecovery { get; set; }
    }
}