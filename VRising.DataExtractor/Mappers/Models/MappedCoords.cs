namespace VRising.DataExtractor.Mappers.Models
{
    public class MappedCoords
    {
        public MappedCoords(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
}