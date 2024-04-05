using System;

namespace VRising.Models.Data
{
    public class AbilityCastConditionModel
    {
        public int ConditionId { get; set; }
        public string FailureText { get; set; }
        public Guid FailureTextGuid { get; set; }
    }
}