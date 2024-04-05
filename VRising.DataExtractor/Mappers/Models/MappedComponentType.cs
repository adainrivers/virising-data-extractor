namespace VRising.DataExtractor.Mappers.Models
{
    public class MappedComponentType
    {
        public string Name { get; set; }

        public AccessMode AccessModeType { get; set; }

        public bool IsManagedComponent { get; set; }

        public bool IsSystemStateSharedComponent { get; set; }

        public bool IsSystemStateComponent { get; set; }

        public bool IsBuffer { get; set; }

        public bool IsChunkComponent { get; set; }

        public bool IsZeroSized { get; set; }

        public bool IsSharedComponent { get; set; }

        public enum AccessMode
        {
            ReadWrite,
            ReadOnly,
            Exclude
        }
    }
}
